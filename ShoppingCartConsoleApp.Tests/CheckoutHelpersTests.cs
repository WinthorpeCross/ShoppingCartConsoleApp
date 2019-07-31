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
    }
}