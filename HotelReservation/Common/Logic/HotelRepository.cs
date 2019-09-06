using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;
using System.Data.Entity;

namespace HotelReservation.Common.Logic
{
    public class HotelRepository : IDisposable, IRepository
    {
        private HotelContext db;

        public HotelRepository(HotelContext context)
        {
            db = context;
        }
        public void Save(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
        }

        public IEnumerable<Client> GetClients()
        {
            return db.Clients;
        }

        public IEnumerable<Day> GetDays()
        {
            return db.Days;
        }

        public IEnumerable<Duration> GetPeriods()
        {
            return db.Durations;
        }

        public IEnumerable<Room> GetRooms()
        {
            return db.Rooms;
        }

        public Client GetClient(int id)
        {
            return db.Clients.Find(id);
        }

        public Day GetDay(int id)
        {
            return db.Days.Find(id);
        }

        public Service GetService(int id)
        {
            return db.Services.Find(id);
        }

        public Duration GetDuration(int id)
        {
            return db.Durations.Find(id);
        }

        public Room GetRoom(int id)
        {
            return db.Rooms.Find(id);
        }

        public void EditService(Service service)
        {
            db.Entry(service).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EditDay(Day day)
        {
            db.Entry(day).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EditRoom(Room room)
        {
            db.Entry(room).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EditDuration(Duration duration)
        {
            db.Entry(duration).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteService(int id)
        {
            Service service = db.Services.Find(id);
            if (service != null)
            {
                db.Services.Remove(service);
                db.SaveChanges();
            }
        }

        public void CreateService(Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();
        }

        public void CreateClient(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
        }

        public IEnumerable<Service> GetServices()
        {
            return db.Services;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}