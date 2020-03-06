namespace Silpo
{
    public class Product
    {
        internal readonly int Price;
        internal readonly string Name;
        internal Category Category;

        public Product(int price, string name, Category category)
        {
            Price = price;
            Name = name;
            Category = category;
        }

        public Product(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
