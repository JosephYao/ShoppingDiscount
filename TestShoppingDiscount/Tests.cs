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
            Assert.Equal(100, discountCalculator.Calculate(Member.Normal, 100, 0));
        }

        [Fact]
        public void Discount_for_vip()
        {
            Assert.Equal(500 * 0.8, discountCalculator.Calculate(Member.VIP, 500, 0));
        }

        [Fact]
        public void No_discount_for_vip()
        {
            Assert.Equal(499, discountCalculator.Calculate(Member.VIP, 499, 0));
        }

        [Fact]
        public void Discount_for_normal()
        {
            Assert.Equal(1000 * 0.85, discountCalculator.Calculate(Member.Normal, 1000, 4));
        }
    }
}