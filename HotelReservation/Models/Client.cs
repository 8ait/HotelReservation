using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public long SerialOfPassport { get; set; }
        public DateTime DateOfBorn {get; set;}
        public bool Sex { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}