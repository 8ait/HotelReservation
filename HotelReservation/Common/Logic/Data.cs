using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReservation.Common.Interfaces;

namespace HotelReservation.Common.Logic
{
    public class Data : IData
    {
        private Dictionary<string, string> _typesOfPages = new Dictionary<string, string>()
        {
            {"Main", "Views/Home/Index.cshtml"}
        };

        public Dictionary<string, string> GetTypesOfPages()
        {
            return _typesOfPages;
        }
    }
}