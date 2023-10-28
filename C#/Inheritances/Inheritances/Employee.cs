using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

            public override string ToString()
        {
            return $"Id:{Id} Name :{Name}";
        }
        public override bool Equals(object? obj)
        {
          if(obj!=null)
            {
                Employee other = obj as Employee;
                return true;
            }
          else
            {
                return false; 
            }
        }
    }
    }

