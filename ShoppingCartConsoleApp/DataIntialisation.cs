using ShoppingCartConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public static class DataIntialisation
    {

        public static List<Discount> DiscountsInitialisation()
        {
            var discounts = new List<Discount>();
            //discounts.Add(new Discount("None", 1M));
            discounts.Add(new Discount("BuyOneGetOneFree", 0.5M));
            discounts.Add(new Discount("BuyThreeForTwo", 0.66M));

            return discounts;
        }

        public static List<Product> AvailableProductsInitialisation(List<Discount> discounts)
        {
            var availableProducts = new List<Product>();
            availableProducts.Add(new Product(1, "Apple", 0.60M, discounts.FirstOrDefault(x => x.Name == "None")));
            availableProducts.Add(new Product(2, "Orange", 0.25M, discounts.FirstOrDefault(x => x.Name == "None")));
            availableProducts.Add(new Product(3, "Banana", 1.0M, null));

            return availableProducts;
        }
    }
}
