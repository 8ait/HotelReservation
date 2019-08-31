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
        Day GetDay(int id);
        Duration GetDuration(int id);
        List<Service> GetServicesOnPage(int currentPage, int itemsOnPage);
        List<Service> ContainsService(string name);
        List<Service> GetSearchService(string name);
        void EditDay(Day day);
        void EditService(int id, string name, int cost);
        void EditDuration(Duration duration);
        void CreateService(string name, int cost);
        void DeleteService(int id);
        int GetCountOfPages(int itemsOnPage);
        int GetValidatePage(int page, int itemsOnPage);
    }
}
