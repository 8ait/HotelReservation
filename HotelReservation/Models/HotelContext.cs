using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelReservation.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}