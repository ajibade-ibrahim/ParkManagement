using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ParkManagement.Domain.Models.Entities;

namespace ParkManagement.Data
{
    public class ParksDbContext : DbContext
    {
        public ParksDbContext([NotNull] DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<NationalPark> NationalParks { get; set; }
    }
}