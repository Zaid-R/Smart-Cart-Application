# Smart Shopping Cart Application

Welcome to the Smart Shopping Cart Application! This application allows users to shop at different stores, add products to their cart, view the cart, calculate the total cost, and manage items in the cart.

## Features

- **Multiple Store Options**: Choose to shop at Grocery, Clothing, or Electronics stores.
- **Add and Remove Products**: Select products from the store and add them to the shopping cart. Remove items from the cart if needed.
- **View Cart Contents**: See the list of items currently in the shopping cart.
- **Calculate Total Cost**: Calculate the total cost of all items in the shopping cart.

## Getting Started

To run the application, follow these steps:

1. **Clone the Repository**: Clone this repository to your local machine.

   ```bash
   git clone https://github.com/yourusername/ShoppingCartApplication.git

2. **Navigate to the Project Directory**: Open a terminal or command prompt and change directory to the project folder.
   ```bash
   cd ShoppingCartApplication

3. **Compile and Run**: Use the dotnet CLI to compile and run the application.
   ```bash
   dotnet run
4. **Follow On-screen Instructions**: Once the application starts, follow the on-screen instructions to navigate through the stores, add products to the cart, view the cart, calculate costs, and exit the application.



## Application Structure
The project is structured as follows:

- **Product.cs**: Defines the Product class and ProductCategory enum.

- **ProductGenerator.cs**: Generates mock products for Grocery, Clothing, and Electronics categories.

- **ShoppingCart.cs**: Implements the ShoppingCart class with methods to manage shopping cart operations.

- **Shop.cs**: Defines the abstract Shop class and specific store implementations (GroceryStore, ClothingStore, ElectronicsStore).

- **Program.cs**: Contains the main entry point for the application. It handles user input and interaction with stores and the shopping cart.

## Notes
The project is structured as follows:

- **Product and Category Management**: Products and categories are managed through predefined lists of names and prices.

	They are generated dynamically based on the selected store category.

- **User Interaction**: User interaction is through a console-based menu system. Use numeric input to select options.

- **Error Handling**: Basic error handling is implemented for user input validation.
