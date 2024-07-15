namespace ShoppingCartApplication
{
    // ProductGenerator.cs


    public class ProductGenerator
    {
        private static Random random = new Random();

        public static Product[] GenerateProducts(ProductCategory category)
        {
            string[] names = { "Apple", "T-Shirt", "Laptop", "Banana", "Jeans", "Smartphone",
                           "Orange", "Sweater", "Tablet", "Grapes", "Jacket", "Monitor" };

            decimal[] prices = { 0.99m, 19.99m, 999.99m, 0.59m, 49.99m, 799.99m,
                             0.89m, 29.99m, 499.99m, 2.99m, 79.99m, 199.99m };
            
            Product[] allProducts = new Product[names.Length];
            
            for (int i = 0; i < names.Length; i++)
            {
                allProducts[i] = new Product(names[i], prices[i], (ProductCategory)(i % 3));
            }

            Product[] categoryProducts = allProducts.Where(x => x.Category == category).ToArray();
            return   categoryProducts.OrderBy(x=>random.Next()).Take(random.Next(2,categoryProducts.Length+1)).ToArray();
        }
    }

}
