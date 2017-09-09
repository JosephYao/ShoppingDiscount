using System;
using ShoppingDiscount;
using Xunit;

namespace TestShoppingDiscount
{
    public class Tests
    {
        private readonly DiscountCalculator discountCalculator = new DiscountCalculator();

        [Fact]
        public void No_discount()
        {
            Assert.Equal(100, discountCalculator.calculate(Member.Normal, 100));
        }

        [Fact]
        public void Discount_for_vip()
        {
            Assert.Equal(500 * 0.8, discountCalculator.calculate(Member.VIP, 500));
        }

        [Fact]
        public void No_discount_for_vip()
        {
            Assert.Equal(499, discountCalculator.calculate(Member.VIP, 499));
        }
    }
}