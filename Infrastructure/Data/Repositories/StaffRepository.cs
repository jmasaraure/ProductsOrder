using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
      public class StaffRepository : IStaffRepository
      {
            private readonly ProductsOrderDbContext _context;
            public StaffRepository(ProductsOrderDbContext context)
            {
                  _context = context;
            }

            public async Task<IReadOnlyList<Staff>> GetStaffAsync()
            {
                  return await _context.Staffs.ToListAsync();
            }

            public async Task<Staff> GetStaffByIdAsync(int staffId)
            {
                  return await _context.Staffs.FindAsync(staffId);
            }
      }
}