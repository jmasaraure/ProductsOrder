using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Contracts
{
      public interface IProductRepository
      {
            Task<Product> GetProductByIdAsync(int productId);
            Task<IReadOnlyList<Product>> GetProductsAsync();
      }
}