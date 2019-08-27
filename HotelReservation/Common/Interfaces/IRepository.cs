using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Models;

namespace HotelReservation.Common.Interfaces
{
    public interface IRepository
    {
        void Save(Client client);

        IEnumerable<Client> GetClients();
        IEnumerable<Day> GetDays();
        IEnumerable<Duration> GetPeriods();

        Client Get(int id);

    }
}
