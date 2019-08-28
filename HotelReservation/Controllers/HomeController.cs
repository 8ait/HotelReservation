using HotelReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        IData _data;
        IRedirector _redirector;
        
        public HomeController(IData data, IRedirector redirector)
        {
            _data = data;
            _redirector = redirector;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPage(int id)
        {
            return RedirectToAction("Index", _redirector.GetPage(id));
        }
    }
}