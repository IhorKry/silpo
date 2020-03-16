namespace Silpo
{
    public class CostByCategory : ICondition
    {
        public int Points { get; private set; }
        private Category Category;

        public CostByCategory(Category category)
        {
            Category = category;
        }

        public bool TestCheck(Check check)
        {
            foreach (var product in check.GetProducts())
            {
                if (product.Category == Category)
                {
                    updatePoints(check);
                    return true;
                }
            }

            return false;
        }

        private void updatePoints(Check check)
        {
            Points = 0;

            foreach (var product in check.GetProducts())
            {
                if (product.Category == Category)
                {
                    Points += product.Price;
                }
            }

        }
    }
}