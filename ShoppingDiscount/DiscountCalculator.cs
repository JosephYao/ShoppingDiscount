using static ShoppingDiscount.Member;

namespace ShoppingDiscount
{
    public class DiscountCalculator
    {
        public double Calculate(Member member, int amount, int count)
        {
            if (HasNormalDiscount(member, amount, count))
                return amount * 0.85;

            if (HasVipDiscount(member, amount))
                return amount * 0.8;

            return amount;
        }

        private bool HasNormalDiscount(Member member, int amount, int count)
        {
            return member == Normal && amount >= 1000 && count >= 4;
        }

        private bool HasVipDiscount(Member member, int amount)
        {
            return member == VIP && amount >= 500;
        }
    }
}