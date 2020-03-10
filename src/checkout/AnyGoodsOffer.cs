using System;

namespace Silpo
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int TotalCost;
        public readonly int Points;

        public AnyGoodsOffer(int totalCost, int points)
        {
            TotalCost = totalCost;
            Points = points;
        }

        public AnyGoodsOffer(int totalCost, int points, DateTime expiration) : base(expiration)
        {
            TotalCost = totalCost;
            Points = points;
        }

        protected override void Apply(Check check)
        {
            if (TotalCost <= check.GetTotalCost())
            {
                check.AddPoints(Points);
            }
        }
    }
}
