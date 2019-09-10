using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int Status { get; set; }
        public int RoomId { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Cost { get; set; }
    }
}