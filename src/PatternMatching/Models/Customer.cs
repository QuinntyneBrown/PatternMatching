using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PatternMatching.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(FirstName), nameof(FirstName), IsUnique = true)]
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Order Order { get; set; }
    }
}
