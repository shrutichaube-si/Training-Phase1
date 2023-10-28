using System.Text.Json.Nodes;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grossPay;
            double netPay = CalculateSalary(5000,2000,out grossPay);
            Console.WriteLine("net")
        

          
        }
        static double CalculateSalary(double bPay,double allowance,out double grosspay)
        {
            grosspay = bPay + allowance;
            double netPay = bPay - (bPay * 0.30);
            return netPay;
        }
    }
}