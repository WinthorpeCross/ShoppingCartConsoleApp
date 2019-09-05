using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingCartConsoleApp.Models
{
    public class ShoppingBasketItem
    {
        public ShoppingBasketItem(Product productOrdered, int quantityOrdered)
        {
            Id = Interlocked.Increment(ref GlobalId);
            ProductOrdered = productOrdered;
            QuantityOrdered = quantityOrdered;
        }

        public static int GlobalId;

        public int Id { get; set; }
        public Product ProductOrdered { get; set; }
        public int QuantityOrdered { get; set; }
    }
}
