using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct : Product,Iorderable
    {
        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public static List<DigitalProduct> Products = new List<DigitalProduct>();
        public void DeliveringProduct()
        {
            Console.WriteLine("Click here for downloading {0}", DownloadLink);
        }

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue?\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (ProductQuantity > 0)
                    Console.WriteLine("go to payment page");
                else
                    Console.WriteLine("product unavailable");
            }
            else
            {
                Console.WriteLine("reverting");
            }
        }

        public void ProcessingPayment()
        {
            Console.WriteLine("Enter debit/credit card details {0}", ProductName);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }
    }
}
