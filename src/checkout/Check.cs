using System.Collections.Generic;

namespace Silpo
{
    public class Check
    {
        private List<Product> Products = new List<Product>();

        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in Products)
            {
                totalCost += product.Price;
            }
            return totalCost;
        }

        internal void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public int GetTotalPoints()
        {
            return GetTotalCost();
        }
    }
}
