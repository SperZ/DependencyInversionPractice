using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class Customer:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }


        public Customer() { }
        public Customer(int id, string firstName, string lastName, string emailAddress, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Address = address;
        }
    }
}
