using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class Student
    {

        public string Name { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int numGrades)
        {
            Name = name;
            Grades = new int[numGrades];
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Length == 0)
                return 0;

            int total = 0;
            foreach (int grade in Grades)
            {
                total += grade;
            }
            return (double)total / Grades.Length;
        }
    }

    
    }
    

