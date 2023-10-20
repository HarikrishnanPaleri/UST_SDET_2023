using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProduct : ElectronicsProduct
    {
        public DigitalProduct(string? productName, double price, double quantity, int warrantyperiod, string?fileFormat) : base(productName, price, quantity, warrantyperiod)
        {
            FileFormat = fileFormat;
        }
        public  string? FileFormat { get; set; }

        public void DisplayDigitalProduct()
        {
            Console.WriteLine("fileFormat:" + FileFormat);
        }
        
    }
}
