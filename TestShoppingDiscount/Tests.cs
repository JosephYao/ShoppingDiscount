using System;
using ShoppingDiscount;
using Xunit;

namespace TestShoppingDiscount
{
    public class Tests
    {
        private readonly DiscountCalculator discountCalculator = new DiscountCalculator();

        [Fact]
        public void No_discount_for_normal_even_if_amount_reach_1000()
        {
            Assert.Equal(1000, discountCalculator.Calculate(Member.Normal, 1000, 3));
        }

        [Fact]
        public void No_discount_for_normal_even_if_count_reach_4()
        {
            Assert.Equal(999, discountCalculator.Calculate(Member.Normal, 999, 4));
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