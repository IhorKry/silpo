using System;

namespace Silpo
{
    public class BonusOffer : Offer
    {
        private IReward Reward;
        private ICondition Condition;

        public BonusOffer(DateTime expiration, IReward reward, ICondition condition) : base(expiration, condition)
        {
            Reward = reward;
            Condition = condition;
        }

        protected override void Apply(Check check)
        {
            Reward.CalcPoints(check, Condition);
        }
    }
}