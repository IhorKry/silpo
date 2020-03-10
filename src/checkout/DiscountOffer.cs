using System;

namespace Silpo
{
    public class DiscountOffer : Offer
    {
        private readonly int Discount;

        public DiscountOffer(int discount, DateTime expiration) : base(expiration)
        {
            Discount = discount;
        }

        protected override void Apply(Check check)
        {
            check.UseDiscount(Discount);
        }
    }
}
