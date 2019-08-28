using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Controllers
{
    public class Redirector: IRedirector
    {
        private Dictionary<int, string> _typesOfPages = new Dictionary<int, string>()
        {
            {0, "Home"},
            {1, "Client" },
            {2, "Reservation" },
            {3, "Room" },
            {4, "Service" },
            {5, "Day" },
            {6, "Period" }
        };

        public string GetPage(int id)
        {
            return _typesOfPages[id];
        }
    }
}