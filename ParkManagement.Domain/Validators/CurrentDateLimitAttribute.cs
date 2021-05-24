using System;
using System.ComponentModel.DataAnnotations;

namespace ParkManagement.Domain.Validators
{
    public sealed class CurrentDateLimitAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value == null || ((DateTimeOffset)value).Date <= DateTimeOffset.Now.Date;
        }
    }
}