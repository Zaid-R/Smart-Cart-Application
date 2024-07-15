using System.Collections.ObjectModel;

namespace ShoppingCartApplication
{
    public abstract class Shop
    {
        protected Product[] products;
        public ReadOnlyCollection<Product> Products => products.AsReadOnly();
        public Shop(ProductCategory category) {
            products = ProductGenerator.GenerateProducts(category);
        }
        
        public void DisplayProducts()
        {
            Console.WriteLine($"\tAvailable products in {this.GetType().Name} Store:");
            int i = 0;
            foreach (var product in products)
            {
                Console.WriteLine($"\t[{i++}] {product}");
            }
        }
    }
}
