using HotelReservation.Common.Interfaces;
using HotelReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservation.Controllers
{
    public class PeriodController : Controller
    {
        IData _data;

        public PeriodController(IData data)
        {
            _data = data;
        }
        // GET: Discount
        public ActionResult Index()
        {
            ViewData["Collection"] = GetPeriods();
            return View();
        }

        private IEnumerable<Duration> GetPeriods()
        {
            return _data.GetPeriods();
        }
    }
}