using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        public string? CollegeName { get; set; }
        public string? CollegePlace { get; set; }


        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name : {0} \nCollege Place: {1}\n", CollegeName, CollegePlace);
        }
    }
}
