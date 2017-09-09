using static ShoppingDiscount.Member;

namespace ShoppingDiscount
{
    public class DiscountCalculator
    {
        public double calculate(Member member, int amount)
        {
            if (member == VIP)
                return amount * 0.8;

            return amount;
        }
    }
}