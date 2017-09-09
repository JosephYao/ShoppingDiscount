using System;
using ShoppingDiscount;
using Xunit;

namespace TestShoppingDiscount
{
    public class Tests
    {
        [Fact]
        public void No_discount()
        {
            var discountCalculator = new DiscountCalculator();

            Assert.Equal(100, discountCalculator.calculate(Member.Normal, 100));
        }
    }
}