using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public Customer(int customerId, string? name, string? phoneNumber, double balance)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public int CustomerId {  get; set; }
        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }
        public double Balance { get; set; }
    }
}
