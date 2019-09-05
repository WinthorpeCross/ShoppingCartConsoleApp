using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingCartConsoleApp.Models
{
    public class Discount
    {
        public Discount(Product productOrdered, int quantityOrdered)
        {
            Id = Interlocked.Increment(ref GlobalId);
            //ProductOrdered = productOrdered;
            //QuantityOrdered = quantityOrdered;
        }

        public static int GlobalId;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountMultiplier { get; set; }
    }
}
