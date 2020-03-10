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

        public override void Apply(Check check)
        {
            if (IsExpired()) return;

            if (TotalCost <= check.GetTotalCost())
            {
                check.AddPoints(Points);
            }
        }
    }
}
