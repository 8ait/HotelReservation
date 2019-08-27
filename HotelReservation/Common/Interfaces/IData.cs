using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Models;

namespace HotelReservation.Common.Interfaces
{
    public interface IData
    {
        IEnumerable<Day> GetDays();
        IEnumerable<Duration> GetPeriods();
    }
}
