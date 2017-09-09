using System;
using ShoppingDiscount;
using Xunit;
using static ShoppingDiscount.DiscountCalculator;

namespace TestShoppingDiscount
{
    public class Tests
    {
        private const int AnyCount = 10;
        private readonly DiscountCalculator discountCalculator = new DiscountCalculator();

        [Fact]
        public void No_discount_for_normal_even_if_amount_reach_1000()
        {
            Assert.Equal(MinimalAmountForNormalDiscount, discountCalculator.Calculate(Member.Normal, MinimalAmountForNormalDiscount, MinimalProductCountForNormalDiscount - 1));
        }

        [Fact]
        public void No_discount_for_normal_even_if_count_reach_4()
        {
            Assert.Equal(MinimalAmountForNormalDiscount - 1, discountCalculator.Calculate(Member.Normal, MinimalAmountForNormalDiscount - 1, MinimalProductCountForNormalDiscount));
        }

        [Fact]
        public void Discount_for_vip()
        {
            Assert.Equal(MinimalAmountForVipDiscount * DiscountForVip, discountCalculator.Calculate(Member.VIP, MinimalAmountForVipDiscount, AnyCount));
        }

        [Fact]
        public void No_discount_for_vip()
        {
            Assert.Equal(MinimalAmountForVipDiscount - 1, discountCalculator.Calculate(Member.VIP, MinimalAmountForVipDiscount - 1, AnyCount));
        }

        [Fact]
        public void Discount_for_normal()
        {
            Assert.Equal(MinimalAmountForNormalDiscount * DiscountForNormal, discountCalculator.Calculate(Member.Normal, MinimalAmountForNormalDiscount, MinimalProductCountForNormalDiscount));
        }
    }
}