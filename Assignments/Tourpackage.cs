using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Tourpackage
    {
        public static  List<Tourpackage>Tourpackages = new List<Tourpackage>();
        public Tourpackage(int packageId, string? destination, string? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public double Price { get; set; }

        public static void HotelReservation()
        {
            Console.WriteLine("Enter BooK Id :");
            int a = Convert.ToInt32(Console.ReadLine());
            lock(Tourpackages) 
            {
            var b = Tourpackages.Find(x=>x.PackageId == a);
                Console.WriteLine("Booking completed  Destination :{0}\tStart Date:{1}\tPrice:{2}",b.Destination,b.StartDate,b.Price);
            }
        }

    }
}
