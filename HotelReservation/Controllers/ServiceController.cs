using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class ServiceController : Controller
    {
        private const int _numberOfServiceOnPage = 7;
        private int _currentPage;
        private List<Service> _service;
        private IData _data;

        // GET: Service
        public ServiceController(IData data)
        {
            _data = data;
            GetPage();
        }

        public void GetPage(int page = 1)
        {
            _currentPage = _data.GetValidatePage(page, _numberOfServiceOnPage);
            _service = _data.GetServicesOnPage(page, _numberOfServiceOnPage);
        }

        public ActionResult LoadPage(int page = 1)
        {
            GetPage(page);
            ViewData["Services"] = _service;
            ViewData["CurrentPage"] = _currentPage;
            ViewData["Pages"] = GetCountOfPages();
            return PartialView();
        }

        public ActionResult SearchPage(string name)
        {
            if (name != null)
            {
                ViewData["SearchName"] = name;
                ViewData["Services"] = _data.GetSearchService(name);
                return PartialView();
            } else
            {
                return RedirectToAction("LoadPage");
            }
        }

        [HttpGet]
        public ActionResult CreateService(string name, int cost)
        {
            _data.CreateService(name, cost);
            return RedirectToAction("LoadPage", new { page = GetCountOfPages() });
        }

        [HttpGet]
        public ActionResult EditService(int id, string name, int cost, int page)
        {
            _data.EditService(id, name, cost);
            return RedirectToAction("LoadPage", new { page = page });
        }

        [HttpGet]
        public ActionResult DeleteService(int id, int page)
        {
            _data.DeleteService(id);
            return RedirectToAction("LoadPage", new { page = page});
        } 

        private int GetCountOfPages()
        {
            return _data.GetCountOfPages(_numberOfServiceOnPage);
        }

        public ActionResult Index()
        {
            ViewData["Services"] = _service;
            ViewData["CurrentPage"] = _currentPage;
            ViewData["Pages"] = GetCountOfPages();
            return View();
        }

    }
}