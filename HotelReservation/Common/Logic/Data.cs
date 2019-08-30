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
            if (currentPage > GetCountOfPages(itemsOnPage))
            {
                currentPage = GetCountOfPages(itemsOnPage);
            }
            int start = currentPage * itemsOnPage - (itemsOnPage - 1);
            int end = currentPage * itemsOnPage;
            if (end > services.Count)
            {
                end = services.Count;
            }
            for (int i = start - 1; i < end; i++)
            {
                servicesOnPage.Add(services[i]);
            }
            return servicesOnPage;
        }

        public int GetCountOfPages(int itemsOnPage)
        {
            if (_repository.GetServices().Count() % itemsOnPage == 0)
            {
                return _repository.GetServices().Count() / itemsOnPage;
            } else
            {
                return _repository.GetServices().Count() / itemsOnPage + 1;
            }
        }

        public void CreateService(string name, int cost)
        {
            Service service = new Service();
            service.Name = name;
            service.Cost = cost;
            _repository.CreateService(service);
        }

        public void DeleteService(int id)
        {
            _repository.DeleteService(id);
        }

        public void EditService(int id, string name, int cost)
        {
            Service service = _repository.GetService(id);
            service.Name = name;
            service.Cost = cost;
            _repository.EditService(service);
        }

        public void EditDuration(Duration duration)
        {
            _repository.EditDuration(duration);
        }
    }
}