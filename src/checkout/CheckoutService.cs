namespace Silpo
{
    public class CheckoutService
    {
        private Check Check;

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
            Check closedCheck = Check;
            Check = null;
            return closedCheck;
        }

        public void UseOffer(AnyGoodsOffer offer)
        {
            if (offer.TotalCost <= Check.GetTotalCost())
            {
                Check.AddPoints(offer.Points);
            }
        }
    }
}
