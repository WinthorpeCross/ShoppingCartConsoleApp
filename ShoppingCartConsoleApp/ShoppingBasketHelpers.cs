using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShoppingCart
{
    public static class ShoppingBasketHelpers
    {
        private static string[] AvailableItems = new[]
        {
            "Apple", "Orange"
        };

        public static List<string> GenerateRamdomShoppingBasket(int itemsToAdd)
        {
            var rng = new Random();
            return Enumerable.Range(1, itemsToAdd).Select(index => AvailableItems[rng.Next(AvailableItems.Length)]).ToList();
        }

        public static int GetItemCount(List<string> shoppingBasket, string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return shoppingBasket.Count(x => regex.IsMatch(x));
        }
    }
}
