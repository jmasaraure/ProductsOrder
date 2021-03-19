using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Shared;

namespace Core.Contracts
{
      public interface IRepository<T> where T : EntityBase
      {
            Task<T> GetByIdAsync(int id);
            Task<IList<T>> GetAllAsync();

      }
}