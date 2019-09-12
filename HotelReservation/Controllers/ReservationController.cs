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
            ViewData["CurrentPage"] = _data.GetValidatePageReservation(page, _itemsOnPage, mode, DateTime.Today);
            ViewData["Pages"] = _data.GetCountOfPagesReservation(_itemsOnPage, mode, DateTime.Today);
            return PartialView();
        }

        public ActionResult Forms(string startDate = null, string endDate = null)
        {
                DateTime start = DateTime.Parse(startDate);
                DateTime end = DateTime.Parse(endDate);
                ViewData["rooms"] = _data.GetRoomsForReservation(start, end);
          
                return PartialView();
        }

        public ActionResult GetRooms(string startDate, string endDate)
        {   
            return RedirectToAction("Forms", new { mode = 1, startDate = startDate, endDate = endDate});
        }
       
    }
}