using System;
using System.ComponentModel.DataAnnotations;
using ParkManagement.Domain.Validators;

namespace ParkManagement.Domain.Models
{
    public class NationalPark
    {
        [CurrentDateLimit(ErrorMessage = "The date created cannot be later than today")]
        public DateTimeOffset? DateCreated { get; set; }

        [CurrentDateLimit(ErrorMessage = "The date established cannot be later than today")]
        public DateTimeOffset? DateEstablished { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
        public byte[] Picture { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string State { get; set; }
    }
}