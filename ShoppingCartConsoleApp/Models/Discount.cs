using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingCartConsoleApp.Models
{
    public class Discount
    {
        public Discount(string name, decimal discountExpression)
        {
            Id = Interlocked.Increment(ref GlobalId);
            Name = name;
            DiscountExpression = discountExpression;
        }

        public static int GlobalId;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountExpression { get; set; }
    }
}
