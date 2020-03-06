namespace Silpo
{
    public class FactorByCategoryOffer: AnyGoodsOffer
    {
        public readonly Category Category;
        public readonly int Factor;


        public FactorByCategoryOffer(Category category, int factor): base(0, 0)
        {
            Category = category;
            Factor = factor;
        }
    }
}
