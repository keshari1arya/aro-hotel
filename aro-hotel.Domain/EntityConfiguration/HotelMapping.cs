using System;
using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class HotelMapping : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(2000);
            builder.Property(p => p.Phone).IsRequired();

            builder.HasOne(x => x.Address);

        }
    }
}

