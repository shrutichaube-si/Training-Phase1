using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeComparer : IComparer<employee>

    {
        public int Compare(employee? x, employee? y)
        {
            int result = 0;
            if (x == null && y == null) { return 0; }
            if (x == null) { return -1; }
            if (y == null) { return 1; }
            if (x.salary == y.salary) { result = 0; }
            if (x.salary < y.salary) { result = 1; }
            return result;
        }
    }
}
