using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class RoomFacilityXREFMapping : IEntityTypeConfiguration<RoomFacilityXREF>
    {
        public void Configure(EntityTypeBuilder<RoomFacilityXREF> builder)
        {
            builder.HasOne(x => x.Room)
                .WithMany(x => x.RoomFacilityXREFs)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Facility)
               .WithMany(x => x.RoomFacilityXREFs)
               .HasForeignKey(x => x.FacilityId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }

}

