namespace ShoppingCartApplication
{
    public enum ProductCategory
    {
        Grocery,
        Clothing,
        Electronics
    }

    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public ProductCategory Category { get; private set; }

        public Product(string name, decimal price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - ${Price}";
        }
    }
}
