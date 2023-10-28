using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Emp
    {
        string name;
        int id;
        int basicpay;
        int salary;
        
        
        public void Display()
        {
            Console.WriteLine("name is"+name+"id is"+id+"basicpay"+basicpay+" salary"+salary);
        }
    }
}
