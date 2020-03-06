using System.Collections.Generic;

namespace Silpo
{
    public class CheckoutService
    {
        private Check Check;

        public void OpenCheck()
        {
            Check = new Check();
            Check.Products = new List<Product>();
            Check.TotalCost = 0;
        }

        public void AddProduct(Product product)
        {
            Check.Products.Add(product);
        }

        public Check CloseCheck()
        {
            foreach (Product product in Check.Products)
            {
                Check.TotalCost += product.Price;
            }
            return Check;
        }
    }
}
