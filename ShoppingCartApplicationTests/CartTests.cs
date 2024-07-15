using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class CartTests
    {
        [Fact]
        public void Adding_And_Removing_Items_From_The_Cart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("Apple", 0.99m, ProductCategory.Grocery);
            Product product2 = new Product("T-Shirt", 19.99m, ProductCategory.Clothing);

            // Act - Add items
            cart.AddItem(product1);
            cart.AddItem(product2);

            // Assert 
            Assert.Equal(2, cart.Items.Count);

            // Act - Remove items
            cart.RemoveItem(0);

            // Assert 
            Assert.Single(cart.Items);
        }

        [Fact]
        public void Validate_Calculation_Of_Total_Cost()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("Apple", 0.99m, ProductCategory.Grocery);
            Product product2 = new Product("T-Shirt", 19.99m, ProductCategory.Clothing);
            Product product3 = new Product("Laptop", 999.99m, ProductCategory.Electronics);

            cart.AddItem(product1);
            cart.AddItem(product2);
            cart.AddItem(product3);

            // Act
            decimal totalCost = cart.CalculateTotalCost();

            decimal expectedTotalCost = 0;
            foreach (var item in cart.Items)
                expectedTotalCost += item.Price;
            // Assert
            Assert.Equal(expectedTotalCost, totalCost);
        }
    }
}