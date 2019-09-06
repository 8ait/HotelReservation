﻿using System;
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

        public IEnumerable<Room> GetRooms()
        {
            return _repository.GetRooms();
        }

        public Day GetDay(int id)
        {
            Day day = _repository.GetDay(id);
            return day;
        }

        public Room GetRoom(int id)
        {
            Room room = _repository.GetRoom(id);
            return room;
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

        public void EditRoom(Room room)
        {
            _repository.EditRoom(room);
        }

        public List<Client> GetClientsOnPage(int currentPage, int itemsOnPage)
        {
            List<Client> clientsOnPage = new List<Client>();
            List<Client> clients = _repository.GetClients().ToList();
            currentPage = GetValidatePageClient(currentPage, itemsOnPage);
            int start = currentPage * itemsOnPage - (itemsOnPage - 1);
            int end = currentPage * itemsOnPage;
            if (end > clients.Count)
            {
                end = clients.Count;
            }
            for (int i = start - 1; i < end; i++)
            {
                clientsOnPage.Add(clients[i]);
            }
            return clientsOnPage;
        }

        public int GetValidatePageClient(int page, int itemsOnPage)
        {
            if (page > GetCountOfPagesClient(itemsOnPage))
            {
                page = GetCountOfPagesClient(itemsOnPage);
            }
            else if (page <= 0)
            {
                page = 1;
            }
            return page;
        }

        public int GetCountOfPagesClient(int itemsOnPage)
        {
            if (_repository.GetClients().Count() % itemsOnPage == 0)
            {
                return _repository.GetClients().Count() / itemsOnPage;
            }
            else
            {
                return _repository.GetClients().Count() / itemsOnPage + 1;
            }
        }

        public List<Service> GetServicesOnPage(int currentPage, int itemsOnPage)
        {
            List<Service> servicesOnPage = new List<Service>();
            List<Service> services = _repository.GetServices().ToList();
            currentPage = GetValidatePage(currentPage, itemsOnPage);
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

        public int GetValidatePage(int page, int itemsOnPage)
        {
            if (page > GetCountOfPages(itemsOnPage))
            {
                page = GetCountOfPages(itemsOnPage);
            } else if (page <= 0)
            {
                page = 1;
            }
            return page;
        }

        public List<Service> ContainsService(string name)
        {
            List<Service> service = new List<Service>();
            List<Service> services = _repository.GetServices().ToList();
            foreach(Service serv in services)
            {
                if (serv.Name.Contains(name))
                {
                    service.Add(serv);
                }
            }
            return service;
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

        public List<Service> GetSearchService(string name)
        {
            List<Service> searchService = new List<Service>();
            List<Service> service = _repository.GetServices().ToList();
            foreach(Service serv in service)
            {
                if (serv.Name.Contains(name))
                {
                    searchService.Add(serv);
                }
            }
            return searchService;
        }

        public void CreateService(string name, int cost)
        {
            Service service = new Service();
            service.Name = name;
            service.Cost = cost;
            _repository.CreateService(service);
        }

        public void CreateClient(string firstName, string secondName, long serial, int sex, string date)
        {
            Client client = new Client();
            client.FirstName = firstName;
            client.SecondName = secondName;
            client.SerialOfPassport = serial;
            client.Sex = Convert.ToBoolean(sex);
            DateTime dateOfBorn = DateTime.Parse(date);
            client.DateOfBorn = dateOfBorn;
            _repository.CreateClient(client);
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