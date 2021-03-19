using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
      public class ProductConfiguration : IEntityTypeConfiguration<Product>
      {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                  builder.Property(d => d.Title).IsRequired().HasMaxLength(50);
                  builder.Property(d => d.Description).IsRequired().HasMaxLength(250);
                  builder.Property(d => d.Price).HasColumnType("decimal(20,5)");
                  builder.Property(d => d.ImageUrl).IsRequired();
                  builder.Property(d => d.DateCreated).IsRequired();
                  builder.Property(d => d.DateModified).IsRequired();
            }
      }
}