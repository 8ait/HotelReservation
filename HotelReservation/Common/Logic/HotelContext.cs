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
    }
}