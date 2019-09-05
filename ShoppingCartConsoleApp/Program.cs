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
            decimal total = 0;

            var discounts = new List<Discount>();
            discounts.Add(new Discount("None", "/ 1 *"));
            discounts.Add(new Discount("BuyOneGetOneFree", "/ 1 * 0.5 *"));
            discounts.Add(new Discount("BuyThreeForTwo", "/ 3 * 2 *"));


            var availableProducts = new List<Product>();
            availableProducts.Add(new Product(1, "Apple", 0.60M, discounts.FirstOrDefault(x => x.Name == "BuyThreeForTwo")));
            availableProducts.Add(new Product(2, "Orange", 0.25M, discounts.FirstOrDefault(x => x.Name == "BuyOneGetOneFree")));

            var shoppingBasket = ShoppingBasketHelpers.GenerateRamdomShoppingBasket(availableProducts);

            total = CheckoutHelpers.CalculateTotal1(shoppingBasket);

            Console.WriteLine();
            Console.WriteLine(String.Format("The total cost after discounts is {0:C}", total));

            var totalLinq = CheckoutHelpers.CalculateTotalLinq(shoppingBasket);
            Console.WriteLine();
            Console.WriteLine(String.Format("The total cost after discounts is {0:C}", totalLinq));

            Console.ReadLine();
        }
    }
}
