namespace Silpo
{
    public class AnyGoodsOffer
    {
        public readonly int TotalCost;
        public readonly int Points;

        public AnyGoodsOffer(int totalCost, int points)
        {
            TotalCost = totalCost;
            Points = points;
        }
    }
}