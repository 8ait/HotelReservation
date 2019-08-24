using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; } 
    }
}