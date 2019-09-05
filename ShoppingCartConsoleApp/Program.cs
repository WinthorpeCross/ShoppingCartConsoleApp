using ShoppingCartConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    
    class Program
    {
        const decimal applePricePerUnit = 0.60M;
        const decimal orangePricePerUnit = 0.25M;



        static void Main()
        {
            decimal total = 0;

            var availableProducts = new List<Product>();
            availableProducts.Add(new Product(1, "Apple", 0.60M, Discounts.None));
            availableProducts.Add(new Product(2, "Orange", 0.25M, Discounts.None));

            var shoppingBasket = ShoppingBasketHelpers.GenerateRamdomShoppingBasket(availableProducts);

            total = CheckoutHelpers.CalculateTotal(shoppingBasket);

            Console.WriteLine();
            Console.WriteLine(String.Format("The total cost after discounts is {0:C}", total));

            var totalLinq = CheckoutHelpers.CalculateTotalLinq(shoppingBasket);
            Console.WriteLine();
            Console.WriteLine(String.Format("The total cost after discounts is {0:C}", totalLinq));

            Console.ReadLine();
        }
    }
}
