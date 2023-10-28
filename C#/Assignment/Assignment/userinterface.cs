using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class userinterface
    {
        public int getId()
        {
            Console.WriteLine("Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public string getName()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            return name;
        }

        public string getDepartment()
        {
            Console.WriteLine("Enter Department:");
            string department = Console.ReadLine();
            return department;
        }

        public double getSalary()
        {
            Console.WriteLine("Enter Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            return salary;

        }
    }
}
