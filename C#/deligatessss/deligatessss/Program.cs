using System.Xml.Serialization;

namespace deligatessss
{
    public delegate void NumberFormatter(double number);
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberDisplay n1= new NumberDisplay();
            NumberFormatter n2 = null;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    n2 = n1.FormatPercantage;
                    break;
                case 2:
                    n2 = n1.FormatCurrency;
                    break;
                default:
                    break;
            }
            n2 += n1.FormatCurrency;
            n2(2.4);
        }
    }
}