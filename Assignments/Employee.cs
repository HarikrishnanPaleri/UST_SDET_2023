using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
        public int EmployeeId;

        public Employee(int employeeId ,string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("FullName:{0},Age: {1}", FirstName +  LastName, Age);
        }
    }

}
