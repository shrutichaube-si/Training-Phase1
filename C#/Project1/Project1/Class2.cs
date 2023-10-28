using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your grade:");
            char grade = Convert.ToChar(Console.ReadLine());
            //nsole.WriteLine("Name:" + name + "\nAge:" + age + "\nGrade:" + grade);
            Console.WriteLine($"Name :{name}\n Age:{age}\n Grade:{grade}");

        }
    }
}
