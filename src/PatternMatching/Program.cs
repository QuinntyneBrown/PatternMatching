using PatternMatching.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = 26;

            if (records is > 25 and < 35)
            {
                Console.WriteLine("Pattern Matching Basic!");
            }


            Console.WriteLine(records switch
            {
                > 25 and < 35 => "Pattern Matching Switch Statements!",
                _ => ""
            });

            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    FirstName = "Quinn",
                    LastName = "Brown",
                    Order = new Order
                    {
                        Category = Category.Socks,
                        ItemId = 22,
                        Quantity = 10,
                        TotalSalePrice = 100.00M
                    }
                },

                new Customer
                {
                    FirstName = "Vanessa",
                    LastName = "Brown",
                    Order = new Order
                    {
                        Category = Category.Pants,
                        ItemId = 1,
                        Quantity = 1,
                        TotalSalePrice = 250.00M
                    }
                },
                new Customer
                {
                    FirstName = "Makayala",
                    LastName = "Brown",
                    Order = new Order
                    {
                        Category = Category.Bib,
                        ItemId = 2,
                        Quantity = 100,
                        TotalSalePrice = 25.00M
                    }
                }

            };

            Console.WriteLine(customers.Find(x => x.Order.TotalSalePrice is > 100 && x.Order.Category is Category.Pants).FirstName);

            var t = customers.First().Order.Category switch
            {
                Category.Pants => "Pants",
            };
        }
    }
}
