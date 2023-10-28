using System.IO;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Library library = new Library();

                while (true)
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Add a book");
                    Console.WriteLine("2. Display book list");
                    Console.WriteLine("3. Search for books by title or author");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter book title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter author name: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter book genre: ");
                            string genre = Console.ReadLine();
                            Console.Write("Enter quantity available: ");
                            int quantityAvailable = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book(title, author, genre, quantityAvailable);
                            library.AddBook(book);
                            Console.WriteLine("Book added successfully!");
                            break;

                        case "2":
                            library.DisplayBooks();
                            break;

                        case "3":
                            Console.Write("Enter search keyword (title or author): ");
                            string keyword = Console.ReadLine();
                            library.SearchByTitleOrAuthor(keyword);
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