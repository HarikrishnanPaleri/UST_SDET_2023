using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        private string? productName;
        private double price, quantity;

        public Product(string? productName, double price, double quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public double SetPrice(double newPrice)
        { 
            price = newPrice;
            return price;
         
        }

        public double ProductValue()
        {
            double value = price * quantity;
            return value;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name:" +  productName);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("Quantity:" + quantity);
        }
        
    }
    
}
