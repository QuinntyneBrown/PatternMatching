using System;
using System.ComponentModel.DataAnnotations;

namespace PatternMatching.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public Category Category { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalSalePrice { get; set; }

    }

}
