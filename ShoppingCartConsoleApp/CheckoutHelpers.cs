
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
    }
}