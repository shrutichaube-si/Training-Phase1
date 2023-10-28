namespace OnlineStoreInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics electronicProduct = new Electronics(1, "Smartphone", 799.99m, 50, "Samsung");
            Clothing clothingProduct = new Clothing(2, "T-Shirt", 19.99m, 100, "Medium");
            Book bookProduct = new Book(3, "The Great Gatsby", 9.99m, 75, "F. Scott Fitzgerald");

            Console.WriteLine("Electronic Product Details:");
            electronicProduct.DisplayDetails();

            Console.WriteLine("\nClothing Product Details:");
            clothingProduct.DisplayDetails();

            Console.WriteLine("\nBook Product Details:");
            bookProduct.DisplayDetails();
        }
    }
}