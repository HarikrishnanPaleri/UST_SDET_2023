using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
     class Student
    {
        public string? name;
        public int mark1,mark2,mark3;

        public Student(string? name, int mark1, int mark2, int mark3)
        {
            this.name = name;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public double CalculateTotalMark()
        {
           
            double Total;
            Total = mark1 + mark2 + mark3;

            return Total;
           
        }
        public double CalculateAverage()
        {
            double average = CalculateTotalMark()/ 3;
            return average;
        }
         
    }
}
