namespace Inheritances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //student s1;
            //Console.WriteLine("Enter 1 for DayScholar and 2 for Hosteller");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        {
            //            s1 = new DayScholar1();
            //            if (s1 is DayScholar1 dayScholar)
            //            {
            //                dayScholar.Name = "Alice";
            //                dayScholar.Department = "ECE";
            //                dayScholar.BusRoute = 234;
            //                dayScholar.BusFee = 3000;
            //                dayScholar.DisplayStudentDetails();
            //            }
            //            break;
            //        }
            //    case 2:
            //        {
            //            s1 = new Hostellar();
            //            if (s1 is Hostellar hostellar)
            //            {
            //                hostellar.Name = "Bob";
            //                hostellar.Department = "IT";
            //                hostellar.RoomNo = 163;
            //                hostellar.DisplayStudentDetails();

            //            }
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Wrong Choice");
            //        break;
            //}

            //student d1 = new DayScholar();
            //d1.Id = 101;
            //d1.Name = "Alice";
            //d1.Department = "ECE";
            //d1.BusRoute = 234;

            //d1.DisplayStudentDetails();

            //Hostellar h1 = new Hostellar();
            //h1.Id = 201;
            //h1.Name = "Bob";
            //h1.Department = "IT";
            //h1.RoomFee = 5600.00;
            //h1.MessFee = 2600.00;

            //h1.DisplayStudentDetails();
            //Console.WriteLine(h1.CalculateFees());

            Console.ReadKey();
            Employee e = new Employee(1, "shruti");
            Console.WriteLine(e.ToString());                   
        }
    }
}
