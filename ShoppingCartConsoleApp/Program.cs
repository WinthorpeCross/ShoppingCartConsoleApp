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

            //List<string> shoppingBasket = new List<string>(new string[] { "Apple", "Apple", "Apple" });
            var shoppingBasket = ShoppingBasketHelpers.GenerateRamdomShoppingBasket(7);
            Console.WriteLine(StringHelpers.BasketSummary(shoppingBasket));


            var totalApples = ShoppingBasketHelpers.GetItemCount(shoppingBasket, @"\b(apple)\b");
            try
            {
                total = total + CheckoutHelpers.UpdateTotal(totalApples, applePricePerUnit);
                Console.WriteLine(StringHelpers.GrossSummary("Apples", totalApples, applePricePerUnit));
            }
            catch
            {
                Console.WriteLine("An error occurred");
                return;
            }

            var totalOranges = ShoppingBasketHelpers.GetItemCount(shoppingBasket, @"\b(orange)\b");
            try
            {
                Console.WriteLine(StringHelpers.GrossSummary("Oranges", totalOranges, orangePricePerUnit));
                total = total + CheckoutHelpers.UpdateTotal(totalOranges, orangePricePerUnit);
            }
            catch
            {
                Console.WriteLine("An error occurred");
                return;
            }

            Console.WriteLine(String.Format("The total net cost is {0:C}", total));
            Console.ReadLine();
        }
    }
}
