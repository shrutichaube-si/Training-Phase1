using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {
        String name { get; set; }
        int rollno { get; set; }
        String coursejoined { get; set; }
        int feespaid { get; set; }
        public Student(String name, int rollno, String coursejoined, int feespaid)
        {
            this.name = name;
            this.rollno = rollno;
            this.coursejoined = coursejoined;
            this.feespaid = feespaid;
        }
        public void Display()
        {
            if(coursejoined == "c#")
            {
                Console.WriteLine("return 2000");
            }
            else
            {
                Console.WriteLine("3000");
            }
            Console.WriteLine("name is:" + name + " roll no :" + rollno + "course joined:" + coursejoined + "feespaid:" + feespaid);
        }
    }
}
