using System.Collections.Generic;
using System.Linq;
using static ShoppingDiscount.Member;

namespace ShoppingDiscount
{
    public class DiscountCalculator
    {
        public const int MinimalProductCountForNormalDiscount = 4;
        public const int MinimalAmountForVipDiscount = 500;
        public const int MinimalAmountForNormalDiscount = 1000;
        public const double DiscountForNormal = 0.85;
        public const double DiscountForVip = 0.8;

        public double Calculate(Member member, int amount, int count)
        {
            var discountOptions = new List<DiscountOption>
            {
                new DiscountOption
                {
                    HasDiscount = HasNormalDiscount(member, amount, count),
                    Amount = amount * DiscountForNormal
                },
                new DiscountOption
                {
                    HasDiscount = HasVipDiscount(member, amount),
                    Amount = amount * DiscountForVip
                },
                new DiscountOption
                {
                    HasDiscount = true,
                    Amount = amount
                },
            };

            return discountOptions.First(op => op.HasDiscount).Amount;
        }

        private bool HasNormalDiscount(Member member, int amount, int count)
        {
            return member == Normal && amount >= MinimalAmountForNormalDiscount && count >= MinimalProductCountForNormalDiscount;
        }

        private bool HasVipDiscount(Member member, int amount)
        {
            return member == VIP && amount >= MinimalAmountForVipDiscount;
        }
    }

    internal class DiscountOption
    {
        public bool HasDiscount { get; set; }
        public double Amount { get; set; }
    }
}