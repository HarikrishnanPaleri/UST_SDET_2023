using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Booktype : Book

    {
        public Booktype(string? title, string? author, int isbn, double price, bool availablity, string? type) : base(title, author, isbn, price, availablity)
        {

            Type = type;
        }

        public string? Type { get; set; }




        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: {0}\nAuthor:{1}\nISBN:{2}\nPrice:{3}\nAvailability:{4}\nType:{5}", Title,Author,Isbn,Price,Availablity,Type);
        }

    }
}
