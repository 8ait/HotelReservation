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
            _currentPage = 1;
            GetPage(_currentPage);
        }

        public void GetPage(int page)
        {
            _currentPage = page;
            _service = _data.GetServicesOnPage(page, _numberOfServiceOnPage);
            Index();
        }

        public ActionResult Index()
        {
            ViewData["Services"] = _service;
            return View();
        }

    }
}