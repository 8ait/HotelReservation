using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Controllers
{
    public class ReservationController : Controller
    {
        private IData _data;
        private const int _itemsOnPage = 7;

        public ReservationController(IData data)
        {
            _data = data;
        }
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadPage(int page = 1, int mode = 0)
        {
            ViewData["Reservations"] = _data.GetReservation(page, _itemsOnPage, DateTime.Today, mode);

            return PartialView();
        }
       
    }
}