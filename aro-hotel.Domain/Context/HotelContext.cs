using System;
using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace aro_hotel.Domain.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<HotelFacilityXREF> HotelFacilityXREFs { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<RoomFacilityXREF> RoomFacilityXREFs { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}

