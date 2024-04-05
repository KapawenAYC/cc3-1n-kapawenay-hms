using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Account
    {
        private string AccountID {  get; set; }
        private string Password { get; set; }

        private Account(string accountID, string password)
        {
            AccountID = accountID;
            Password = password;
        }
    }
}
