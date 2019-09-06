using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Controllers
{
    public class ClientController : Controller
    {
        private IData _data;
        private const int _itemsOnPage = 7;

        public ClientController(IData data)
        {
            _data = data;
        }
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadPage(int page = 1)
        {
            ViewData["Clients"] = _data.GetClientsOnPage(page, _itemsOnPage);
            ViewData["CurrentPage"] = _data.GetValidatePageClient(page, _itemsOnPage);
            ViewData["Pages"] = _data.GetCountOfPagesClient(_itemsOnPage);
            return PartialView();
        }
    }
}