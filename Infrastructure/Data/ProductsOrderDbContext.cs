using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
      public class ProductsOrderDbContext : DbContext
      {
            public ProductsOrderDbContext(DbContextOptions<ProductsOrderDbContext> options) : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
            public DbSet<Staff> Staffs { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                  base.OnModelCreating(modelBuilder);
                  modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
      }
}