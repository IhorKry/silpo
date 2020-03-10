using System;

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

        public FactorByCategoryOffer(Category category, int factor, DateTime expiration) : base(expiration)
        {
            Category = category;
            Factor = factor;
        }

        public override void Apply(Check check)
        {
            if (IsExpired()) return;

            int points = check.GetCostByCategory(Category);
            check.AddPoints(points * (Factor - 1));
        }
    }
}
