using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;

namespace HotelReservation.Controllers
{
    public class RoomController : Controller
    {
        private IData _data;

        public RoomController(IData data)
        {
            _data = data;
        }
        // GET: Room
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetRooms()
        {
            ViewData["Rooms"] = _data.GetRooms().ToList();
            return PartialView();
        }

        public ActionResult EditRoom(int id, int numberOfPlaces, int category, int cost)
        {
            Room room = _data.GetRoom(id);
            room.NumberOfPlaces = numberOfPlaces;
            room.Category = category;
            room.Cost = cost;
            _data.EditRoom(room);
            return RedirectToAction("GetRooms");
        }
    }
}