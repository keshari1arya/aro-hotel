using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class HotelMultimediaXREFMapping : IEntityTypeConfiguration<HotelMultimediaXREF>
    {
        public void Configure(EntityTypeBuilder<HotelMultimediaXREF> builder)
        {
            builder.HasOne(x => x.Hotel)
                .WithMany(x => x.HotelMultimediaXREFs)
                .HasForeignKey(x => x.HotelId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Multimedia)
               .WithMany(x => x.HotelMultimediaXREFs)
               .HasForeignKey(x => x.MultimediaId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }

}

