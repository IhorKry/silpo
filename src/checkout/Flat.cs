namespace Silpo
{
    public class Flat : IReward
    {
        public void CalcPoints(Check check, ICondition condition)
        {
            check.AddPoints(condition.Points);
        }
    }
}