using System;

namespace Silpo
{
    public class FactorByCategoryOffer : Offer
    {
        private readonly Category Category;
        private readonly int Factor;

        public FactorByCategoryOffer(Category category, int factor)
        {
            Category = category;
            Factor = factor;
        }

        public FactorByCategoryOffer(Category category, int factor, DateTime expiration) : base(expiration)
        {
            Category = category;
            Factor = factor;
        }

        protected override void Apply(Check check)
        {
            int points = check.GetCostByCategory(Category);
            check.AddPoints(points * (Factor - 1));
        }
    }
}
