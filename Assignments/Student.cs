﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        /*
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
        */


        private string? studentname, grade;
        private int[] mark = new int[3];

        public Student(string? studentname, string? grade, int[] mark)
        {
            Studentname = studentname;
            Grade = grade;
            Mark = mark;
        }

        public string? Studentname { get => studentname; set => studentname = value; }
        public string? Grade { get => grade; set => grade = value; }

        public int[] Mark { get => mark; set => mark = value; }

        public double CalculateAverage()
        {
            double average = Mark.Average();
            Console.WriteLine("Average:" + average);
            return average;
        }
        public void DisplayStudents()
        {
            Console.WriteLine("Student Name:" + Studentname);
            Console.WriteLine("Grade:" + grade);
            int i = 1, total = 0;
            foreach (int mrk in mark)
            {
                Console.WriteLine("Mark {0};{1}", i, mrk);
                i++;
                total += mrk;
            }
            Console.WriteLine("Total:" + total);
        }

        public void GetMarksSummary()
        {
            int highest = mark[0];
            int lowest = mark[0];
            foreach (int mrk in mark)

            {
                if (mrk > highest) { highest = mrk; }
                if (mrk < lowest) { lowest = mrk; }
            }
                Console.WriteLine("Highest:" + highest);
                Console.WriteLine("Lowest:" + lowest);

            
        }
    }

}
       
        
        
    

