namespace Silpo
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int TotalCost;
        public readonly int Points;

        public AnyGoodsOffer(int totalCost, int points) : base()
        {
            TotalCost = totalCost;
            Points = points;
        }

        public override void apply(Check check)
        {
            if (TotalCost <= check.GetTotalCost())
            {
                check.AddPoints(Points);
            }
        }
    }
}
