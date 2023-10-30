 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct : Product, Iorderable
    {
        public double Weight { get; set; }
        public string? Dimension { get; set; }

        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();

        public void DeliveringProduct()
        {
            Console.WriteLine("product shipment completed and shipping cost is {0}", Weight * 10);
        }

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue?\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (ProductQuantity > 0)
                    Console.WriteLine("continue to the payment page");
                else
                    Console.WriteLine("product is unavailable at the moment");
            }
            else
            {
                Console.WriteLine("reverting");
            }

        }

        public void ProcessingPayment()
        {
            Console.WriteLine("Enter debit/credit card details for {0}", ProductName);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment completed");
            }
        }
    }
}
