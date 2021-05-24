using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkManagement.Data.Repositories.Contracts;

namespace ParkManagement.Data.Repositories.EFCore
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EfGenericRepository(ParksDbContext dbContext)
        {
            Context = dbContext;
            DbSet = Context.Set<T>();
        }

        protected readonly ParksDbContext Context;

        protected readonly DbSet<T> DbSet;

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }
    }
}