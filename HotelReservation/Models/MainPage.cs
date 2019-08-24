using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class MainPage
    {
        private Dictionary<int, string> _pages = new Dictionary<int, string>()
        {
            {0, "Главная" },
            {1, "Клиенты" },
            {2, "Бронь" },
            {3, "Скидки" },
            {4, }
        };
    }
}