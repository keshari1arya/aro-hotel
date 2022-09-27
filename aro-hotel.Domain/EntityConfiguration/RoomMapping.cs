using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class RoomMapping : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(p => p.Occupancy).IsRequired();

            builder.HasOne(x => x.Hotel)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.HotelId);

            builder.HasOne(x => x.RoomType)
                .WithMany(x => x.Rooms)
                .HasForeignKey(x => x.RoomTypeId);
        }
    }

}

