using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    internal class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int employeeID, decimal salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public abstract decimal CalculateBonus();
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, int employeeID, decimal salary)
            : base(name, employeeID, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * 0.2m; // 20% bonus for managers
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }

    class Developer : Employee
    {
        public Developer(string name, int employeeID, decimal salary)
            : base(name, employeeID, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * 0.1m; // 10% bonus for developers
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(string name, int employeeID, decimal salary)
            : base(name, employeeID, salary)
        {
        }

        public override decimal CalculateBonus()
        {
            return Salary * 0.15m; // 15% bonus for salespeople
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }
}
