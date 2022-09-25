using System;
using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace aro_hotel.Domain.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}

