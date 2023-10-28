using Inheritances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritances
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CollegeFee { get; set; } = 4500;
        public string Department { get; set; }

        public virtual void DisplayStudentDetails()
        {
            Console.WriteLine("----------------Student_Details----------------");
            Console.WriteLine($"Id : {Id}\t Name : {Name}\t Department: {Department}");
        }

    }
    class DayScholar1 : student
    {
        public int BusRoute { get; set; }
        public double BusFee { get; set; }
        public double CalculateFees()
        {
            CollegeFee = CollegeFee + BusFee;
            return CollegeFee;
        }

        public void DisplayStudentDetails()
        {

            Console.WriteLine($"Bus Route : {BusRoute} Total Fee : {BusFee}");
        }

    }
    class Hostellar : student
    {
        public int RoomNo { get; set; }
        public double RoomFee { get; set; }
        public double MessFee { get; set; }
        public double CalculateFees()
        {
            CollegeFee = CollegeFee + MessFee + RoomFee;
            return CollegeFee;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Room No : {RoomNo} \t CollegeFee : {CollegeFee}");
        }
    }
}
