using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer1
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }

        public List<DigitalProduct> ordersdigital = new List<DigitalProduct>();
        public List<PhysicalProduct> ordersdigitalphysical = new List<PhysicalProduct>();
        public List<DigitalProduct> confirmedordersdigital = new List<DigitalProduct>();
        public List<PhysicalProduct> confirmedordersdigitalphysical = new List<PhysicalProduct>();
        public static List<Customer1> customers = new List<Customer1>();
    }
}

