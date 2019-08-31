using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int NumberOfPlaces { get; set; }
        public int Category { get; set; }
        public int Cost { get; set; }
    }
}