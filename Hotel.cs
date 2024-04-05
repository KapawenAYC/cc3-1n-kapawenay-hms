using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hotel_Management
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }
        private static List<HotelRoom> Rooms = new List<HotelRoom>();
        public Hotel(string name, string location, List<HotelRoom> rooms)
        {
            HotelName = name;
            Location = location;
            Rooms = rooms;
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {HotelName} - Available Rooms");
            foreach (var room in Rooms)
            {
                Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {HotelName} - Booked Rooms");

        }
        
        public void DisplayDetails()
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
            }
        }

        public void ReserveRoom(HotelRoom room)
        {
        }
    }
}

    