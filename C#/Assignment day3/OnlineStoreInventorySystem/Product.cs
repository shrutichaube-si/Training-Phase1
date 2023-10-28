using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreInventorySystem
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }


        public Product(int id, string name, decimal price, int quantity)
        {
            ProductID = id;
            Name = name;
            Price = price;
            QuantityInStock = quantity;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }

    }
    class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(int id, string name, decimal price, int quantity, string brand)
            : base(id, name, price, quantity)
        {
            Brand = brand;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    class Clothing : Product
    {
        public string Size { get; set; }

        public Clothing(int id, string name, decimal price, int quantity, string size)
            : base(id, name, price, quantity)
        {
            Size = size;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}");
        }
    }
    class Book : Product
    {
        public string Author { get; set; }

        public Book(int id, string name, decimal price, int quantity, string author)
            : base(id, name, price, quantity)
        {
            Author = author;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {Author}");
        }
    }

}
