using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ShoppingCartApplication
{
    class Program
    {
        private static string getKey(int from, int to)
        {
            string difficultyInput;
            Regex regex = new Regex($"^[{from}-{to}]$");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                difficultyInput = keyInfo.KeyChar.ToString();

                if (regex.IsMatch(difficultyInput))
                {
                    break;
                }

                Console.Write($"\nPlease enter a number between {from} and {to}: ");
            }
            return difficultyInput;
        }

        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();
            ElectronicsStore electronicsStore = new ElectronicsStore();

            try
            {
                while (true)
                {
                    Console.WriteLine("Welcome to the Smart Shopping Cart!");
                    Console.WriteLine("1. Shop at Grocery Store");
                    Console.WriteLine("2. Shop at Clothing Store");
                    Console.WriteLine("3. Shop at Electronics Store");
                    Console.WriteLine("4. View Cart");
                    Console.WriteLine("5. Calculate Total Cost");
                    Console.WriteLine("6. Exit");
                    Console.Write("Select an option: ");
                    string option = getKey(1, 6);
                    Console.WriteLine(option + "\n");

                    switch (option)
                    {
                        case "1":
                        case "2":
                        case "3":
                            Shop store = option switch
                            {
                                "1" => groceryStore,
                                "2" => clothingStore,
                                "3" => electronicsStore,
                                _ => throw new NotImplementedException(),
                            };
                            store.DisplayProducts();
                            Console.Write("Select a product to add to cart (index): ");
                            int productIndex = int.Parse(getKey(0, store.Products.Count - 1));
                            var product = store.Products[productIndex];
                            if (product != null)
                            {
                                cart.AddItem(product);
                            }
                            break;

                        case "4":
                            cart.ViewItems();
                            Console.Write("Do you want to remove an item? (yes/no): ");
                            string removeOption = Console.ReadLine();
                            if (removeOption.ToLower() == "yes")
                            {
                                cart.ViewItems();
                                Console.Write("Enter the index of the product to remove: ");
                                productIndex = int.Parse(getKey(0, cart.Items.Count - 1));
                                cart.RemoveItem(productIndex);
                            }
                            break;

                        case "5":
                            decimal totalCost = cart.CalculateTotalCost();
                            Console.WriteLine($"Total cost: {totalCost:C}");
                            break;

                        case "6":
                            Console.WriteLine("Thank you for shopping with us!");
                            return;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

        }
    }

}
