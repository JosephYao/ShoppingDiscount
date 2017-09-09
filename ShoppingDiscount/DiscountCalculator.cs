using static ShoppingDiscount.Member;

namespace ShoppingDiscount
{
    public class DiscountCalculator
    {
        public double calculate(Member member, int amount)
        {
            if (HasVipDiscount(member, amount))
                return amount * 0.8;

            return amount;
        }

        private bool HasVipDiscount(Member member, int amount)
        {
            return member == VIP && amount >= 500;
        }
    }
}