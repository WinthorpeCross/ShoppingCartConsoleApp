using NCalc;
using ShoppingCartConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace ShoppingCart
{
    
    class Program
    {
        static void Main()
        {
            var discounts = new List<Discount>();
            discounts.Add(new Discount("None", 1M));
            discounts.Add(new Discount("BuyOneGetOneFree", 0.5M));
            discounts.Add(new Discount("BuyThreeForTwo", 0.66M));

            var availableProducts = new List<Product>();
            availableProducts.Add(new Product(1, "Apple", 0.60M, discounts.FirstOrDefault(x => x.Name == "None")));
            availableProducts.Add(new Product(2, "Orange", 0.25M, discounts.FirstOrDefault(x => x.Name == "None")));

            var shoppingBasket = ShoppingBasketHelpers.GenerateRamdomShoppingBasket(availableProducts);

            decimal total = 0M;

            total = CheckoutHelpers.CalculateTotalLinq(shoppingBasket);
            Console.WriteLine();
            Console.WriteLine($"The total cost after discounts is {total:C}");

            Console.ReadLine();
        }
    }
}
