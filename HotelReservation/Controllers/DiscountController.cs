using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Models;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Controllers
{
    public class DiscountController : Controller
    {
        IData _data;

        public DiscountController(IData data)
        {
            _data = data;
        }
        // GET: Discount
        public ActionResult Index()
        {
                ViewData["Day"] = true;
                ViewData["Collection"] = GetDays();
            return View();
        }

        private IEnumerable<Day> GetDays()
        {
            return _data.GetDays();
        }

        private IEnumerable<Duration> GetPeriods()
        {
            return _data.GetPeriods();
        }

        public ActionResult Duration()
        {
            ViewData["Day"] = false;
            ViewData["Collection"] = GetPeriods();
            return View("Index");
        }
    }
}