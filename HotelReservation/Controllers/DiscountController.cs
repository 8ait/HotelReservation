using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class DiscountController : Controller
    {
        private IData _data;

        bool _day = true;
        bool _period = false;

        public DiscountController(IData data)
        {
            _data = data;
        }
        // GET: Discount
        public ActionResult Index()
        {
            ViewData["Collection"] = _data.GetDays();
            return View();
        }

        public ActionResult Days()
        {
            ViewData["Collection"] = _data.GetDays();
            return PartialView();
        }

        public ActionResult Periods()
        {
            ViewData["Collection"] = _data.GetPeriods();
            return PartialView();
        }

        [HttpGet]
        public ActionResult EditModel(int id, int count, bool modeOfEdit)
        {
            if (modeOfEdit == _day)
            {
                Day day = _data.GetDay(id);
                day.Discount = count;
                _data.EditDay(day);
                return RedirectToAction("Days");
            } else
            {
                Duration duration = _data.GetDuration(id);
                duration.Discount = count;
                _data.EditDuration(duration);
                return RedirectToAction("Periods");
            }
        }
    }
}