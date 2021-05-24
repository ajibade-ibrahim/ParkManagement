using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkManagement.Data.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}