namespace Silpo
{
    public class TotalCost : ICondition
    {
        private readonly int MinLimit;
        public int Points { get; }

        public TotalCost(int minLimit, int points)
        {
            MinLimit = minLimit;
            Points = points;
        }

        public bool TestCheck(Check check)
        {
            return check.GetTotalCost() > MinLimit;
        }
    }
}