namespace Silpo
{
    public class CheckoutService
    {
        private Check Check;
        private Offer Offer;

        public void OpenCheck()
        {
            Check = new Check();
        }

        public void AddProduct(Product product)
        {
            if (Check == null)
            {
                OpenCheck();
            }

            Check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            if(Offer != null) Offer.Use(Check);
            Check closedCheck = Check;
            Check = null;
            return closedCheck;
        }

        public void UseOffer(Offer offer)
        {
            Offer = offer;
        }
    }
}
