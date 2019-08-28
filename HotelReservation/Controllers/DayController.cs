using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Logic;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;
using System.Web.Script.Serialization;

namespace HotelReservation.Controllers
{
    public class DayController : Controller
    {

        IData _data;

        public DayController(IData data)
        {
            _data = data;
        }
        // GET: Discount
        public ActionResult Index()
        {
            ViewData["Collection"] = GetDays();
            return View();
        }

        private IEnumerable<Day> GetDays()
        {
            return _data.GetDays();
        }

        [HttpGet]
        public ActionResult EditModel(int id, int count)
        {
            Day day = _data.GetDay(id);
            day.Discount = count;
            _data.EditDay(day);
            return RedirectToAction("Index");
        }
    }
}