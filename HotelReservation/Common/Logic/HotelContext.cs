using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HotelReservation.Models;

namespace HotelReservation.Common.Logic
{
    public class HotelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Duration> Durations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RS> RSs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RS>()
                .HasKey(rs => new { rs.ReservationId, rs.SeviceId });
        }
    }
}