using System;

namespace Silpo
{
    abstract public class Offer
    {
        public readonly DateTime Expiration;

        public Offer()
        {
            Expiration = DateTime.MaxValue;
        }

        public Offer(DateTime expiration)
        {
            Expiration = expiration;
        }

        public abstract void Apply(Check check);

        public virtual bool isExpired()
        {
            int result = DateTime.Compare(Expiration, DateTime.Today);

            return result < 0;
        }
    }
}
