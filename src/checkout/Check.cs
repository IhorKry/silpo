using System.Collections.Generic;

namespace Silpo
{
    public class Check
    {
        private List<Product> Products = new List<Product>();
        private int Points;

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
            return GetTotalCost() + Points;
        }

        internal void AddPoints(int points)
        {
            Points += points;
        }

        public int GetCostByCategory(Category category)
        {
            int result = 0;
            
            foreach (var product in Products)
            {
                if (product.Category == category)
                {
                    result += product.Price;
                }
            }

            return result;
        }
    }
}
