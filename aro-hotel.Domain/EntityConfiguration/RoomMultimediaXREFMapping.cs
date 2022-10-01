using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class RoomMultimediaXREFMapping : IEntityTypeConfiguration<RoomMultimediaXREF>
    {
        public void Configure(EntityTypeBuilder<RoomMultimediaXREF> builder)
        {
            builder.HasOne(x => x.Room)
                .WithMany(x => x.RoomMultimediaXREFs)
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Multimedia)
               .WithMany(x => x.RoomMultimediaXREFs)
               .HasForeignKey(x => x.MultimediaId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }

}

