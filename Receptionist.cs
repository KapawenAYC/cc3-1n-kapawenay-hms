using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Receptionist : User
    {
        public Receptionist(string name, string address, string email, string phoneNumber)
       : base(name, address, email, phoneNumber);
    }
    public void BookReservation(Guest guest, Reservation reservation)
    {
    }
}
