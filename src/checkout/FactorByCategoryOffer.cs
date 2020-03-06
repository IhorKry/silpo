namespace Silpo
{
    public class FactorByCategoryOffer : Offer
    {
        public readonly Category Category;
        public readonly int Factor;


        public FactorByCategoryOffer(Category category, int factor)
        {
            Category = category;
            Factor = factor;
        }

        public override void apply(Check check)
        {
            int points = check.GetCostByCategory(Category);
            check.AddPoints(points * (Factor - 1));
        }
    }
}
