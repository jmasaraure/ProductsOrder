using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Contracts
{
      public interface IStaffRepository
      {
            Task<Staff> GetStaffByIdAsync(int staffId);
            Task<IReadOnlyList<Staff>> GetStaffAsync();
      }
}