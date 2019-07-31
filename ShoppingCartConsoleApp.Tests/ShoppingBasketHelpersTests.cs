using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.UnitTests
{
    public class ShoppingBasketHelpersTests
    {

        // These tests are better tested with a theory.
        // Xunit cannot serialise List, so tested like this unnecessary time setting up alternative

        [Fact]
        public void CheckListCount()
        {
            List<string> shoppingBasket = new List<string>(new string[] { "Apple", "Apple", "Apple" });

            var expected = 3;

            var result = ShoppingBasketHelpers.GetItemCount(shoppingBasket, @"\b(apple)\b");

            Assert.Equal(result, expected);
        }

        [Fact]
        public void CheckListCountWithCaseSensitivity()
        {
            List<string> shoppingBasket = new List<string>(new string[] { "Apple", "APPLE", "apple" });

            var expected = 3;

            var result = ShoppingBasketHelpers.GetItemCount(shoppingBasket, @"\b(apple)\b");

            Assert.Equal(result, expected);
        }

        [Fact]
        public void CheckListCountWithNoMatches()
        {
            List<string> shoppingBasket = new List<string>(new string[] { "", "Appl", "Orange", "Peach" });

            var expected = 0;

            var result = ShoppingBasketHelpers.GetItemCount(shoppingBasket, @"\b(apple)\b");

            Assert.Equal(result, expected);
        }
    }
}
