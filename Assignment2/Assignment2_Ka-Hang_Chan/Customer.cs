using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Ka_Hang_Chan
{
    internal class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public Customer (string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    }
}
