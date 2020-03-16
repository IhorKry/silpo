namespace Silpo
{
    public interface IReward
    {
        void CalcPoints(Check check, ICondition condition);
    }
}