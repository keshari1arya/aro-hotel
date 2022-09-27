using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class HotelFacilityXREFMapping : IEntityTypeConfiguration<HotelFacilityXREF>
    {
        public void Configure(EntityTypeBuilder<HotelFacilityXREF> builder)
        {
            builder.HasOne(x => x.Hotel)
                .WithMany(x => x.HotelFacilityXREFs)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Facility)
               .WithMany(x => x.HotelFacilityXREFs)
               .HasForeignKey(x => x.FacilityId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }

}

