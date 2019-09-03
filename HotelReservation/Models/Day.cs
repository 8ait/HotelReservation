using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class Day
    {
        public int DayId { get; set; }

        [Display(Name = "Скидка")]
        public int Discount { get; set; }
    }
}