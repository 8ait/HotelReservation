using HotelReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;
using HotelReservation.Common.Helpers;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        IRepository _repository;
        
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(HelperLayout.Main());
        }
    }
}