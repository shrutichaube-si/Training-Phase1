using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name}Salary:{Department}";
        }
        public override bool Equals(Object? obj)
        {
            return base.Equals(Object ? obj){

            }
        }
    }

}
