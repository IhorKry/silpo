using System;

namespace Silpo
{
    abstract public class Offer
    {
        private readonly DateTime Expiration;
        private ICondition Condition;

        public Offer()
        {
            Expiration = DateTime.MaxValue;
        }

        public Offer(DateTime expiration)
        {
            Expiration = expiration;
        }

        public Offer(DateTime expiration, ICondition condition)
        {
            Expiration = expiration;
            Condition = condition;
        }

        protected abstract void Apply(Check check);

        public void Use(Check check)
        {
            if (IsExpired()) return;
            if ((Condition != null) && (!Condition.TestCheck(check))) return;

            Apply(check);
        }

        public bool IsExpired()
        {
            return Expiration < DateTime.Today;
        }
    }
}
