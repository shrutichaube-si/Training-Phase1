using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    
    
    internal class InheritanceDemo
    {
        /*public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }*/
        public void  print()
        {
            Console.WriteLine("hello");
        }
        public void DisplayStudentDetails()
        {
           // Console.WriteLine(Id+ " " + Name+" "+Department);
        }
        
    }
    class DayScholar : InheritanceDemo
    {
        public void display()
        {
            Console.WriteLine("hello world");
        }
       
    }
    /*class Hostellar : InheritanceDemo
    {
        public int BusRoute { get; set; }
    }*/
}
