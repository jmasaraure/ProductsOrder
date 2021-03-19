using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
      public class ProductRepository : IProductRepository
      {
            private readonly ProductsOrderDbContext _context;
            public ProductRepository(ProductsOrderDbContext context)
            {
                  _context = context;
            }

            public async Task<Product> GetProductByIdAsync(int productId)
            {
                  return await _context.Products.FindAsync(productId);
            }

            public async Task<IReadOnlyList<Product>> GetProductsAsync()
            {
                  return await _context.Products.ToListAsync();
            }
      }
}