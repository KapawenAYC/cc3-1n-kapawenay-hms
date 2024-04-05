using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Guest : User
    {
        private static List<Reservation> reservations = new List<Reservation>();
        public int TotalBookedRooms { get; set; }

        public Guest(string name, string address, string email, string phoneNumber)
            : base(name, address, email, phoneNumber);

    }
}
