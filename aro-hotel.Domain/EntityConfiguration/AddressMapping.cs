using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aro_hotel.Domain.EntityConfiguration
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.Line1).IsRequired();
            builder.Property(p => p.City).IsRequired();
            builder.Property(p => p.State).IsRequired();
            builder.Property(p => p.Country).IsRequired();
            builder.Property(p => p.Pincode).IsRequired();
        }
    }

}

