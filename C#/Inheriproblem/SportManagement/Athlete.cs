using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportManagement
{
    internal class Athlete
    {
        public int AthleteId;
        public string FirstName;
        public string LastName;
        public int Age;
        public string Sport;
        public DateTime RegDate;

        public Athlete(string fn,string ln,int age,string sport,DateTime reg)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = age;
            this.Sport = sport;
            this.RegDate = reg;
        }
    }
}
