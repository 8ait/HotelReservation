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
        IData _data;

        public ReservationController(IData data)
        {
            _data = data;
        }
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadPage(int page)
        {
            return PartialView();
        }
       
    }
}