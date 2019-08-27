using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservation.Controllers
{
    public class DiscountController : Controller
    {
        // GET: Discount
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Discount()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Service()
        {
            return RedirectToAction("Index", "Service");
        }

        public ActionResult Reservation()
        {
            return RedirectToAction("Index", "Reservation");
        }

        public ActionResult Client()
        {
            return RedirectToAction("Index", "Client");
        }

        public ActionResult Room()
        {
            return RedirectToAction("Index", "Room");
        }

        public ActionResult Main()
        {
            return RedirectToAction("Main", "Home");
        }
    }
}