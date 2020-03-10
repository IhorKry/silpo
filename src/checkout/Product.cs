namespace Silpo
{
    public class Product
    {
        internal readonly int Price;
        internal readonly string Name;
        internal readonly Category Category;
        internal readonly Brand Brand;

        public Product(int price, string name, Category category, Brand brand)
        {
            Price = price;
            Name = name;
            Category = category;
            Brand = brand;
        }

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
