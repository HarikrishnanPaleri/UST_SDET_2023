using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public  string? Name { get; set; }
        public string? Country {  get; set; }   
        public double Rating { get; set; }

      public static  List<TourismDestination> tourd = new List<TourismDestination>();
        public static void SortCountry()
        {
            var result = tourd.OrderByDescending(s => s.Rating);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name+" "+item.Country+" "+item.Rating);
            }
            
        }
    }
}
