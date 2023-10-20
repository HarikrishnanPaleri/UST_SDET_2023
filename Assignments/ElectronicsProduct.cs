using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProduct:Product
    {
        public ElectronicsProduct(string? productName, double price, double quantity,int warrantyperiod) : base(productName, price, quantity)
        {
            WarrantyPeriod = warrantyperiod;
        }

        public int WarrantyPeriod { get; set; }

        public void DisplayWarranty()
        {
            Console.WriteLine("Warranty Period:" + WarrantyPeriod);
        }

    }
  
}
