using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        
    public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public int QuantityAvailable { get; set; }

        public Book(string title, string author, string genre, int quantityAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            QuantityAvailable = quantityAvailable;
        }
    }

    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
            else
            {
                Console.WriteLine("Book List:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
            }
        }

        public void SearchByTitleOrAuthor(string keyword)
        {
            List<Book> matchingBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || book.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    matchingBooks.Add(book);
                }
            }

            if (matchingBooks.Count == 0)
            {
                Console.WriteLine("No matching books found.");
            }
            else
            {
                Console.WriteLine("Matching Books:");
                foreach (var book in matchingBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.QuantityAvailable}");
                }
            }
        }
    }

 
   




    
}
