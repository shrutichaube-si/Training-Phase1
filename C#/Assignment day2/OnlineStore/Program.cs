using System.IO;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Store store = new Store();

            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display product list");
                Console.WriteLine("3. Calculate total value of products in stock");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter quantity in stock: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter product category: ");
                        string category = Console.ReadLine();
                        Product product = new Product(name, price, quantity, category);
                        store.AddProduct(product);
                        Console.WriteLine("Product added successfully!");
                        break;

                    case "2":
                        store.DisplayProducts();
                        break;

                    case "3":
                        double totalValue = store.CalculateTotalValue();
                        Console.WriteLine($"Total value of products in stock: ${totalValue:F2}");
                        break;

                    case "4":
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}