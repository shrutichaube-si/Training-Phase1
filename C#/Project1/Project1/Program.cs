namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of hours worked by an employee");
            int hours =(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter the rate per hour");
            float rate =(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Payslip");
            Console.WriteLine("===========================");
            Console.WriteLine("Hours Worked           "+hours);
            float rates = Convert.ToSingle(rate);
            Console.WriteLine("Hourly Rate            "+rates);
            float grosspay = hours * rates;
            Console.WriteLine("Gross Pay              "+ grosspay);

            float insurance = (grosspay * 5 / 100);
            Console.WriteLine("National Insurance     "+insurance);
            float incometax = grosspay - insurance;
            float income = (incometax * 20 / 100);
            Console.WriteLine("Income Tax             "+income);


        }

        }
}