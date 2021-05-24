using System;
using System.Collections.Generic;
using System.Text;

namespace ParkManagement.Domain.Models
{
    public class NationalPark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateEstablished { get; set; }
    }
}
