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
            Check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            return Check;
        }
    }
}
