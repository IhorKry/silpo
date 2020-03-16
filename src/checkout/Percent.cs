namespace Silpo
{
    public class Percent : IDiscountRule
    {
        public Discount CalcDiscount(Check check)
        {
            return new Discount();
        }
    }
}