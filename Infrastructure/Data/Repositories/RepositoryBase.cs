using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities.Shared;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
      public class RepositoryBase<T> : IRepository<T> where T : EntityBase
      {
            private readonly ProductsOrderDbContext _context;
            public RepositoryBase(ProductsOrderDbContext context)
            {
                  _context = context;
            }
            public async Task<IList<T>> GetAllAsync()
            {
                  return await _context.Set<T>().ToListAsync();
            }

            public async Task<T> GetByIdAsync(int id)
            {
                  return await _context.Set<T>().FindAsync(id);
            }
      }
}