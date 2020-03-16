namespace Silpo
{
    public interface IDiscountRule
    {
        Discount CalcDiscount(Check check);
    }
}