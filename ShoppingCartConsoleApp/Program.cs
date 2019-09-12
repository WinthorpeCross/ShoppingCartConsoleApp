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
            List<Discount> availableDiscounts = DataIntialisation.DiscountsInitialisation();

            List<Product> availableProducts = DataIntialisation.AvailableProductsInitialisation(availableDiscounts);

            List<ShoppingBasketItem> shoppingBasket = ShoppingBasketHelpers.GenerateRamdomShoppingBasket(availableProducts);

            StringHelpers.BasketSummary2(shoppingBasket);

            decimal total = 0M;

            total = CheckoutHelpers.CalculateTotalLinq(shoppingBasket);
            Console.WriteLine();
            Console.WriteLine($"The total cost after discounts is {total:C}");

            total = 0M;
            total = CheckoutHelpers.CalculateTotalLoop(shoppingBasket);
            Console.WriteLine();
            Console.WriteLine($"The total cost after discounts is {total:C}");

            Console.ReadLine();
        }
    }
}
