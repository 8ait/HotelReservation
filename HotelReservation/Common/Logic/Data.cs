using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;

namespace HotelReservation.Common.Logic
{
    public class Data : IData
    {
        IRepository _repository;

        public Data (IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Day> GetDays()
        {
             return _repository.GetDays();
        }

        public IEnumerable<Duration> GetPeriods()
        {
            return _repository.GetPeriods();
        }

        public Day GetDay(int id)
        {
            Day day = _repository.GetDay(id);
            return day;
        }

        public Duration GetDuration(int id)
        {
            Duration duration = _repository.GetDuration(id);
            return duration;
        }

        public void EditDay(Day day)
        {
            _repository.EditDay(day);
        }

        public List<Service> GetServicesOnPage(int currentPage, int itemsOnPage)
        {
            List<Service> servicesOnPage = new List<Service>();
            List<Service> services = _repository.GetServices().ToList();
            int start = currentPage * itemsOnPage - (itemsOnPage - 1);
            int end = currentPage * itemsOnPage;
            for (int i = start; i <= end; i++)
            {
                servicesOnPage.Add(services[i]);
            }
            return servicesOnPage;
        }

        public void EditDuration(Duration duration)
        {
            _repository.EditDuration(duration);
        }
    }
}