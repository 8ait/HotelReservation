using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReservation.Common.Interfaces;
using HotelReservation.Models;

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

        public Client Get(int id)
        {
            return db.Clients.Find(id);
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