using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<HotelRoom<T>> hr = new();
        public static void BookRoom(int roomnu, ref T roomtype)
        {
            HotelRoom<T> hroom = new(roomnu, roomtype, true);
            hr.Add(hroom);
            Console.WriteLine("Room Booking completed,RoomNumber is :{0},Room type: {1}", hroom.RoomNumber, hroom.RoomType);

        }
        public static void CancelRoom(int roomnu)
        {
            foreach (var i in hr)
            {
                if(i.RoomNumber == roomnu)
                {
                    i.IsBooked = false;
                    Console.WriteLine("your booking is cancelled");
                    break;
                }
            }
          
        }
    }
}
