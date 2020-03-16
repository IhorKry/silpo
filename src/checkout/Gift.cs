namespace Silpo
{
    public class Gift : IDiscountRule
    {
        public Discount CalcDiscount(Check check)
        {
            return new Discount();
        }
    }
}