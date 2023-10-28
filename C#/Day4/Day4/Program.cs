using System.Security.Cryptography.X509Certificates;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employe> employeList = new List<employe>();
            public employe Createmploye(int id, string name,string department, double salary)
            {
            employe employe = new employe() { Name=name,Department=department,Salary=salary};
                return employe;

            }
            public bool AddEmploye(employe emp) { 
            if(employeList.Count==0){
                    employeList.Add(emp);
                }
                else
                {
                    foreach(employe e in EmployeList)
                    {

                    }
                }
        }
    }
}