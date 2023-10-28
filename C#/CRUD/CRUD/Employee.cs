using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRUD
{
    internal class Employee
    {
        int Id;
        string Name;
        string Department;
        double Salary;


        List<Employee> employeeList = new List<Employee>()
        {
            new Employee(){Id=1, Name="Alice", Department="Finance",Salary=30000 },
            new Employee(){Id=2, Name="Bob", Department="HR",Salary=45000 },
            new Employee(){Id=3, Name="Wasi", Department="Finance",Salary=35000 },
            new Employee(){Id=4, Name="Anne", Department="IT",Salary=50000 },
            new Employee(){Id=5, Name="Ved", Department="Content",Salary=40000 },
        };

        public Employee CreateEmployee(int id, string name, string depart, double salary)
        {
            Employee employee = new Employee() { Id = id, Name = name, Department = depart, Salary = salary };
            return employee;
        }



        public bool AddEmployee(Employee emp)
        {
            if (employeeList.Count == 0)
            {
                employeeList.Add(emp);
            }
            else
            {
                foreach (Employee employee in employeeList)
                {
                    if (employee.Equals(emp))
                    {

                        return false;
                    }
                    else
                    {
                        employeeList.Add(emp);
                        break;
                    }
                }
            }
            return true;
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("****Employee Details***");
            Console.WriteLine("*************");
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }
        }






    }
}
    