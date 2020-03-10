using System;

namespace Silpo
{
    public class FactorByBrandOffer : Offer
    {
        private readonly Brand Brand;
        private readonly Category Category;
        private readonly int Factor;

        public FactorByBrandOffer(Category category, int factor, DateTime expiration, Brand brand) : base(expiration)
        {
            Category = category;
            Factor = factor;
            Brand = brand;
        }

        protected override void Apply(Check check)
        {
            int points = check.GetCostByBrand(Brand);
            check.AddPoints(points * (Factor - 1));
        }
    }
}
