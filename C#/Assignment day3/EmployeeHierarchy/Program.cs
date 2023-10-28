namespace EmployeeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Manager manager = new Manager("John Doe", 101, 60000m);
            Developer developer = new Developer("Alice Smith", 201, 75000m);
            SalesPerson salesPerson = new SalesPerson("Bob Johnson", 301, 50000m);

            Console.WriteLine("Manager Details:");
            manager.DisplayDetails();

            Console.WriteLine("\nDeveloper Details:");
            developer.DisplayDetails();

            Console.WriteLine("\nSalesPerson Details:");
            salesPerson.DisplayDetails();
        }
    }
}