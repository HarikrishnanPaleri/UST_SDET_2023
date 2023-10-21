using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public Customer(int customerId, string? customername, string? phoneNumber)
        {
            CustomerId = customerId;
            Customername = customername;
            PhoneNumber = phoneNumber;
        }

        public int CustomerId { get; set; }
        public string? Customername { get; set; }
        public string? PhoneNumber { get; set; }



        public void DisplayCustomerDetails() 
        
        {
            Console.WriteLine("Customer Id: {0}\nCustomer Name: {1}\nCustomer PhoneNo: {2}",CustomerId,Customername,PhoneNumber);
        }
    }
}
