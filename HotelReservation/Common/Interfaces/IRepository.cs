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
        IEnumerable<Service> GetServices();

        Client GetClient(int id);
        Day GetDay(int id);
        Duration GetDuration(int id);
        Service GetService(int id);
        void EditDay(Day day);
        void EditDuration(Duration duration);
        void EditService(Service service);
        void DeleteService(int id);
        void CreateService(Service service);

    }
}
