namespace Silpo
{
    public class Factor : IReward
    {
        private readonly int LocalFactor;

        public Factor(int factor)
        {
            LocalFactor = factor;
        }

        public void CalcPoints(Check check, ICondition condition)
        {
            check.AddPoints(condition.Points * LocalFactor);
        }
    }
}
