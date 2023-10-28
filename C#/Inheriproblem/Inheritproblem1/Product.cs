using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritproblem1
{
    internal class Product
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set;  }
        public int Quantity { get; set; }
        public Product(int pid,string name,int price,int quan)
        {
            Product_Id=pid;
            Name = name;
            Price = price;
            Quantity = quan;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Product id :{Product_Id}");
            Console.WriteLine($"Name :{Name}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Quantity:{Quantity}");
        }
        
    }
    class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics()
        {

        }
        public void Display(string brand)
        {
            Console.WriteLine($"Brand :{Brand}");
        }

    }
}
