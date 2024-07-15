using System.Collections.ObjectModel;

namespace ShoppingCartApplication
{
    // ShoppingCart.cs

    public class ShoppingCart
    {
        private static List<Product> items;
        public ReadOnlyCollection<Product> Items => items.AsReadOnly();
        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product product)
        {
            items.Add(product);
            Console.WriteLine($"{product.Name} added to the cart.");
        }

        public void RemoveItem(int index)
        {
            var removedItemName = items[index].Name;
            items.RemoveAt(index);
            Console.WriteLine($"\t{removedItemName} removed from the cart.");
        }

        public void ViewItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in your cart:");
                int i = 0;
                foreach (var item in items)
                {
                    Console.WriteLine($"\t[{i++}] {item}");
                }
            }
        }

        public decimal CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }
    }

}
