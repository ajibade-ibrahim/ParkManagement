using ParkManagement.Domain.Models.Entities;

namespace ParkManagement.Data.Repositories.EFCore
{
    public class NationalParkRepository : EfGenericRepository<NationalPark>
    {
        public NationalParkRepository(ParksDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}