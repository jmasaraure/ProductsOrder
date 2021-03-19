using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
      public class StaffConfiguration : IEntityTypeConfiguration<Staff>
      {
            public void Configure(EntityTypeBuilder<Staff> builder)
            {
                  builder.Property(d => d.FirstName).IsRequired().HasMaxLength(50);
                  builder.Property(d => d.LastName).IsRequired().HasMaxLength(50);
                  builder.Property(d => d.AddressType).IsRequired();
                  builder.Property(d => d.StreetAddress).IsRequired();
                  builder.Property(d => d.Suburb).IsRequired();
                  builder.Property(d => d.City).IsRequired();
                  builder.Property(d => d.PostalCode).IsRequired();
            }
      }
}