using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book
    {
        public Book(string? title, string? author, int isbn, double price, bool availablity)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Price = price;
            Availablity = availablity;
        }

        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Isbn { get; set; }
        public double Price {  get; set; }
        public bool Availablity {  get; set; }

        public void AddBook(string?title, string?author,int isbn,double price,bool availability)
        { 
            Title = title;
            Author = author;
            Isbn = isbn;
            Price = price;
            Availablity = availability;

        }
    }
}
