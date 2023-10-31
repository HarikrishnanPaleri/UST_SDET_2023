using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee1
    {
        public int EmployeeId {  get; set; }
        public string? Name {  get; set; }
        public double PerformanceRatig {  get; set; }

       // List<Employee1> employee1 = new List<Employee1>();
        public static double CalculateBonus(double perr)
        {
            double bonus =perr * 100;
            Console.WriteLine("bonus:");
            return bonus;
        }
        public static double CalculateBonus1(double perr)
        {
            double bonus = perr * 50*100;
            Console.WriteLine("bonus:");
            return bonus;
        }
    }
}
