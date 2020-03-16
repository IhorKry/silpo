namespace Silpo
{
    public interface ICondition
    {
        int Points { get; }

        bool TestCheck(Check check);
    }
}