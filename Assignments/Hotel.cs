using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, string? country, double rating, string? hotelName, int availableRooms) : base(name, country, rating)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }

        public string? HotelName { get; set; }
        public int? AvailableRooms { get; set; }

        public async Task<bool> BookRooms(int RoomsRequested)
        {
            if (RoomsRequested <= AvailableRooms)
            {   
                await Task.Delay(1000);
                AvailableRooms -= RoomsRequested;
                Console.WriteLine($"{RoomsRequested} Booked. Available rooms are : {AvailableRooms}");
                return true;
            }
            else
            {
                Console.WriteLine("we don't have enough rooms");
                return false;
            }
        }

    }
}