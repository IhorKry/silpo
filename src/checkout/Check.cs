using System.Collections.Generic;

namespace Silpo
{
    public class Check
    {
        private List<Product> Products = new List<Product>();
        private int Points;
        private int Discount = 0;

        public int GetTotalCost()
        {
            int totalCost = 0;

            foreach (Product product in Products)
            {
                totalCost += product.Price;
            }

            if (Discount != 0)
            {
                var discount = Discount * totalCost / 100;
                totalCost -= discount;
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

        public int GetCostByBrand(Brand brand)
        {
            int result = 0;

            foreach (var product in Products)
            {
                if (product.Brand == brand)
                {
                    result += product.Price;
                }
            }

            return result;
        }

        public void UseDiscount(int discount)
        {
            Discount = discount;
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
