using System;
using System.Collections.Generic;
using System.Text;

namespace ParkManagement.Data.Repositories.Contracts
{
    public interface INationalParkRepository<T> : IGenericRepository<T> where T : class
    {
    }
}
