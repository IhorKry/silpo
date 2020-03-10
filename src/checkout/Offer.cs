using System;

namespace Silpo
{
    abstract public class Offer
    {
        private readonly DateTime Expiration;

        public Offer()
        {
            Expiration = DateTime.MaxValue;
        }

        public Offer(DateTime expiration)
        {
            Expiration = expiration;
        }

        protected abstract void Apply(Check check);

        public void Use(Check check)
        {
            if (IsExpired()) return;
            Apply(check);
        }

        public bool IsExpired()
        {
            return Expiration < DateTime.Today;
        }
    }
}
