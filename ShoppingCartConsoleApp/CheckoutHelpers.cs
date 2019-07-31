using System;

namespace ShoppingCart
{
    public static class CheckoutHelpers
    {
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
