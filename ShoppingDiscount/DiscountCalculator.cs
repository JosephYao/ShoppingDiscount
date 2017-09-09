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
            if (HasNormalDiscount(member, amount, count))
                return amount * DiscountForNormal;

            if (HasVipDiscount(member, amount))
                return amount * DiscountForVip;

            return amount;
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
}