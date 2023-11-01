using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double Rating {  get; set; }
        public double PricePerNight {  get; set; }

        

        public TouristDestination(string? name, string? location, double rating, double pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }


        public static void TourDestination()
        {
            List<TouristDestination> tourdes = new List<TouristDestination>();
            tourdes.Add(new TouristDestination("Casa", "TVM", 4.5, 2400));
            tourdes.Add(new TouristDestination("vasa", "kvm", 3.5, 2100));
            tourdes.Add(new TouristDestination("pasa", "ovm", 5, 2200));
            tourdes.Add(new TouristDestination("tasa", "jvm", 2, 2000));

            Console.WriteLine("rating above 3");
            List<TouristDestination> tourdes1 = (List<TouristDestination>)tourdes.FindAll(t => t.Rating >= 3);
            foreach (var item in tourdes1)
            {
                Console.WriteLine(item.Name + " " + item.Location + "" + item.Rating);
            }
            Console.WriteLine("based on pricing");
            var result = tourdes.OrderBy(t => t.PricePerNight);
            foreach (var item in result)
            { 
            Console.WriteLine(item.Name + " " + item.Location + "" + item.Rating);
        }
            Console.WriteLine("Based on location search");
            List<TouristDestination> tourdes3 = (List<TouristDestination>)tourdes.FindAll(t => t.Location == "TVM");

            foreach (var item in tourdes3)
            {
                Console.WriteLine(item.Name + " " + item.Location + "" + item.Rating);
            }

        }
    }
}
