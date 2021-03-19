using System.Collections.Generic;
using System.Linq;
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

            public async Task<IList<Product>> GetProductsAsync()
            {
                  var result = await _context.Products.OrderBy(p => p.Title).ToListAsync();
                  return result;
            }
      }
}