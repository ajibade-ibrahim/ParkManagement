using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ParkManagement.Domain.Models;

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
