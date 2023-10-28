using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class employeeUtility
    {
        List<employee> employeeList = new List<employee>()
       {
            new employee(){id=1, name="Shruti", department="Data and Video Tech",salary=70000 },
            new employee(){id=2, name="Adii", department="HR",salary=45000 },
            new employee(){id=3, name="Arbaz", department="IT",salary=65000 },
            new employee(){id=4, name="Jai", department="IT",salary=60000 },
            new employee(){id=5, name="ritika", department="Content",salary=40000 },
        };



        public employee CreateEmployee(int id, string name, string department, double salary)
        {
            employee emp = new employee()
            { name = name, department = department, salary = salary, id = id };
            return emp;
        }



        public bool AddEmployee(employee emp)
        {
            if (employeeList.Count == 0)
            {
                employeeList.Add(emp);
            }
            else
            {
                foreach (employee employee in employeeList)
                {
                    if (employee.Equals(emp))
                    {
                        return false;
                    }
                    else
                    {
                        employeeList.Add(emp);
                    }
                }
            }
            return true;

        }
        public void SearchByName(string name)
        {
            foreach (employee emp in employeeList)
            {
                if (emp.name.Equals(name))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");
                }
            }
        }

        public void SearchById(int id)
        {
            foreach (employee emp in employeeList)
            {
                if (emp.id.Equals(id))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");
                }
            }
        }

        public void SearchByDepartment(string department)
        {
            foreach (employee emp in employeeList)
            {
                if (emp.department.Equals(department))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");

                }
            }
        }
        public List<employee> SortEmployeeBySalary()
        {
            employeeList.Sort(new EmployeeComparer());
            return employeeList;
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("================================");
            foreach (employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }
        }
    }
}

