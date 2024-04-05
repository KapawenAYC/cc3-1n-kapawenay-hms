using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class User
    {
        private string phoneNumber;
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        private int PhoneNumber { get; set; }

        public User(string name, string address, string email, string phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
