using ShoppingCartConsoleApp.Models;
using System;
using Xunit;

namespace ShoppingCart.UnitTests
{
    public class CheckoutHelpersTests
    {
        [Fact]
        public void UpdateTotalWithNoItems()
        {
            var expected = 0M;

            var result = CheckoutHelpers.UpdateTotal(0, 0.25M);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void UpdateTotalWithItems()
        {
            var expected = 1.25M;

            var result = CheckoutHelpers.UpdateTotal(5, 0.25M);

            Assert.Equal(result, expected);
        }



        [Fact]
        public void UpdateTotalWithBuyOneGetOneFreeDiscount()
        {
            var expected = 1M; //8 Apples @ £0.25

            var result = CheckoutHelpers.UpdateTotal(8, 0.25M, Discounts.BuyOneGetOneFree);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1)] //1 Apple @ £0.25 = £0.25
        [InlineData(2)] //2 Apples @ £0.25 = £0.25
        public void UpdateTotalWithBuyOneGetOneFreeDiscountTheory(int quantity)
        {
            var expected = 0.25M;

            var result = CheckoutHelpers.UpdateTotal(quantity, 0.25M, Discounts.BuyOneGetOneFree);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void UpdateTotalWithThreeForTwo()
        {
            var expected = 2.40M; //6 Oranges @ £0.60 = £2.40

            var result = CheckoutHelpers.UpdateTotal(6, 0.60M, Discounts.BuyThreeForTwo);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(2)] //2 Oranges @ £0.60 = £1.20
        [InlineData(3)] //3 Oranges @ £0.60 = £1.20
        public void UpdateTotalWithThreeForTwoTheory(int quantity)
        {
            var expected = 1.20M;

            var result = CheckoutHelpers.UpdateTotal(quantity, 0.60M, Discounts.BuyThreeForTwo);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void UpdateTotalWithNegativeQuantity()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => CheckoutHelpers.UpdateTotal(-5, 0.25M));

        }
    }
}