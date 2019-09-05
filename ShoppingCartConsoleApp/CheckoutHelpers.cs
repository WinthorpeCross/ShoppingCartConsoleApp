using ShoppingCartConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public static class CheckoutHelpers
    {

        public static decimal CalculateTotal(List<ShoppingBasketItem> basket)
        {
            decimal tot = 0M;
            foreach(var item in basket)
            {
                tot = tot + item.ProductOrdered.UnitCost * item.QuantityOrdered;
            }
            return tot;
        }

        public static decimal CalculateTotal1(List<ShoppingBasketItem> basket)
        {
            decimal tot = 0M;
            foreach (var item in basket)
            {
                
                switch (item.ProductOrdered.Discount)
                {
                    case Discounts.None:
                        tot = tot + item.ProductOrdered.UnitCost * item.QuantityOrdered;
                        break;

                    case Discounts.BuyOneGetOneFree:
                        tot = tot + Math.Ceiling((decimal)item.QuantityOrdered / 1 * 0.5M) * item.ProductOrdered.UnitCost;
                        break;

                    case Discounts.BuyThreeForTwo:
                        tot = tot + Math.Ceiling((decimal)item.QuantityOrdered / 3 * 2) * item.ProductOrdered.UnitCost;
                        break;
                }
            }
            return tot;
        }

        public static decimal CalculateTotalLinq(List<ShoppingBasketItem> basket)
        {
            return basket.Sum(x => x.ProductOrdered.UnitCost * x.QuantityOrdered);
        }


        public static decimal UpdateTotal(int qty, decimal price)
        {
            if (qty < 0)
            {
                throw new System.ArgumentOutOfRangeException("Quantity");
            }

            return qty * price;
        }

        public static decimal UpdateTotal(int qty, decimal price, Discounts discount)
        {
            if (qty < 0)
            {
                throw new System.ArgumentOutOfRangeException("Quantity");
            }

            decimal subTotal = 0;

            switch (discount)
            {
                case Discounts.None:
                    subTotal = qty * price;
                    break;

                case Discounts.BuyOneGetOneFree:
                    subTotal = Math.Ceiling((decimal)qty / 1 * 0.5M) * price;
                    break;

                case Discounts.BuyThreeForTwo:
                    subTotal = Math.Ceiling((decimal)qty / 3 * 2) * price;
                    break;
            }

            return subTotal;
        }
    }
}
