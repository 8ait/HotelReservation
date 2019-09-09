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
        IEnumerable<Room> GetRooms();
        Day GetDay(int id);
        Duration GetDuration(int id);
        Room GetRoom(int id);
        List<Service> GetServicesOnPage(int currentPage, int itemsOnPage);
        List<Client> GetClientsOnPage(int currentPage, int itemsOnPage);
        List<Service> ContainsService(string name);
        List<Service> GetSearchService(string name);
        List<Client> GetSearchClient(long serial);
        void EditDay(Day day);
        void EditClient(int id, string firstName, string secondName, long serial, int sex, string dateOfBorn);
        void EditService(int id, string name, int cost);
        void EditDuration(Duration duration);
        void EditRoom(Room room);
        void CreateService(string name, int cost);
        void CreateClient(string firstName, string secondName, long serial, int sex, string dateOfBorn);
        void DeleteService(int id);
        void DeleteClient(int id);
        int GetCountOfPages(int itemsOnPage);
        int GetValidatePage(int page, int itemsOnPage);
        int GetValidatePageClient(int page, int itemsOnPage);
        int GetCountOfPagesClient(int itemsOnPage);
    }
}
