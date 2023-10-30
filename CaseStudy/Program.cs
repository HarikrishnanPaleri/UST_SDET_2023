/*
using CaseStudy;
using static System.Reflection.Metadata.BlobBuilder;
//Customer customer = new Customer("Hari","Payyanur",123);
//customer.DisplayCustomerDetails();

string? title;
int num;
do { 
    Console.WriteLine("BABA BOOKS");
    Console.WriteLine("1.Add Book\n2.Add Customer\n3.Place order\n4.Search Book\n.5 Exit");
    Console.WriteLine("Choose the option");
   int option = Convert.ToInt32(Console.ReadLine());
    Order order = new Order();
    Booktype[] bkt = new Booktype[]
{
    new("Harry Potter","JK",12,500,true,"Fiction"),
    new("He-Man","Hari",44,10000,true,"Fiction")
};
switch (option)
{
    case 1:
        Console.WriteLine("Added Succesfully");
        foreach (Booktype b in bkt)
        {
            b.DisplayDetails();

        }
        break;

        case 2:
        int customerid;
        string? customername;
        string? phonenumber;
        Console.WriteLine("Enter Customer Id");
        customerid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Customer Name");

        customername = Console.ReadLine();
        Console.WriteLine("Enter Phone Number");
        phonenumber = Console.ReadLine();

        Customer customer = new Customer(customerid, customername,phonenumber);
        customer.DisplayCustomerDetails();
        break;

        case 3:
        Console.WriteLine("Enter Title");
            title = Console.ReadLine();
        foreach (var book in bkt)
        {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine("Enter order date");
                    order.OrderDt = Console.ReadLine();
                    Console.WriteLine("order placed");
                    Console.WriteLine("Book Title:{0}", book.Title);
                    Console.WriteLine("Price:{0}", book.Price);
                    Console.WriteLine("Availability:{0}", book.Availablity);
                    order.TotalCost = book.Price;
                    Console.WriteLine("Total Cost:{0}", order.TotalCost);


                }
                //else
                //{
                //    Console.WriteLine("book unavailable");
                //}
        }
        break;

        case 4:
        Console.WriteLine("Enter Title:");
        title= Console.ReadLine();
        foreach (var book in bkt)
        {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine("Book Title:{0}", book.Title);
                    Console.WriteLine("Book Price:{0}", book.Price);
                    Console.WriteLine("Book Availability{0}:", book.Availablity);
                    order.TotalCost = book.Price;
                    Console.WriteLine("Total Cost:{0}", order.TotalCost);
                }
                //else
                //{
                //   Console.WriteLine("book unavailable");
                //}

        }
            break;

        case 5:
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("invaild option");
        break;
}
Console.WriteLine("Do you Want to Continue");
num =Convert.ToInt32(Console.ReadLine());
}while (num != 0) ;

*/

using CaseStudy;

Customer1 cus0 = new Customer1();
cus0.CustomerID = 1;
cus0.CustomerName = "Hari";
cus0.CustomerEmail = "Hari@gmail.com";
Customer1.customers.Add(cus0);
Customer1 cus1 = new Customer1();
cus1.CustomerID = 2;
cus1.CustomerName = "adi";
cus1.CustomerEmail = "adi@gmail";
Customer1.customers.Add(cus1);
Customer1 cus2 = new Customer1();
cus2.CustomerID = 3;
cus2.CustomerName = "abhi";
cus2.CustomerEmail = "abhi@ust";
Customer1.customers.Add(cus2);
Console.WriteLine("_________________________Wellcome to E-Commerce ____________________________");

while (true)
{
    Console.WriteLine("Select your option\n1.User page\n2.Admin page");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)

    {
        Console.WriteLine("Enter the customer id");
        int cusId = Convert.ToInt32(Console.ReadLine());
        if (Customer1.customers.Find(x => x.CustomerID == cusId) == null)
        {
            Console.WriteLine("Customer not found");
            break;
        }
        while (true)
        {
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view ordersdigital");
            int optionuser = Convert.ToInt32(Console.ReadLine());

            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customer1 customer1 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            customer1.ordersdigitalphysical.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        customer1.ordersdigital.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                    break;
                case 2:
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                    }
                    break;
                case 3:
                    Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer.ordersdigital.Count == 0 && customer.ordersdigitalphysical.Count == 0)
                    {
                        Console.WriteLine("no product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.ordersdigital)
                        {
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                             item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer.ordersdigitalphysical)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight in Kg:{4}" +
                           "\tDimension in inches:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();
                        }
                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedordersdigital.AddRange(customer.ordersdigital);
                            customer.ordersdigital.Clear();
                            customer.confirmedordersdigitalphysical.AddRange(customer.ordersdigitalphysical);
                            customer.ordersdigitalphysical.Clear();
                            Console.WriteLine("order placed successfully");
                        }
                        else
                        {
                            Console.WriteLine("removing everything in cart");
                        }


                    }



                    break;
                case 4:
                    Console.WriteLine("call this number for support 96456636727");
                    break;
                case 5:
                    Customer1 customer2 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedordersdigital.Count == 0 && customer2.confirmedordersdigitalphysical.Count == 0)
                    {
                        Console.WriteLine("no order details found");
                    }
                    else
                    {
                        Console.WriteLine("ordersdigital are");
                        foreach (var item in customer2.confirmedordersdigital)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer2.confirmedordersdigitalphysical)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("invalid input");

                    break;
            }

            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
            int optuser = Convert.ToInt32(Console.ReadLine());
            if (optuser == 1)
            {
                continue;
            }
            else if (optuser == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }


    }

    else if (option == 2)
    {
        Console.WriteLine("choose option\n1.Add Product\n2.View report");
        int optionadmin = Convert.ToInt32(Console.ReadLine());
        if (optionadmin == 1)
        {
            Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
            int optionProduct = Convert.ToInt32(Console.ReadLine());
            if (optionProduct == 1)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the fileformat");
                string? fileFormat = Console.ReadLine();
                Console.WriteLine("Enter downloadLink");
                string? downloadLink = Console.ReadLine();


                DigitalProduct digitalProduct = new DigitalProduct();
                digitalProduct.ProductName = productName;
                digitalProduct.ProductId = productid;
                digitalProduct.FileFormat = fileFormat;
                digitalProduct.DownloadLink = downloadLink;
                digitalProduct.Price = productCost;
                DigitalProduct.Products.Add(digitalProduct);
            }
            else if (optionProduct == 2)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Weight");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter dimension");
                string? dimension = Console.ReadLine();

                PhysicalProduct physicalProduct = new PhysicalProduct();
                physicalProduct.ProductName = productName;
                physicalProduct.ProductId = productid;
                physicalProduct.Price = productCost;
                physicalProduct.Dimension = dimension;
                physicalProduct.Weight = weight;

                PhysicalProduct.Products.Add(physicalProduct);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
    else
    {
        Console.WriteLine("invalid option");
    }
    Console.WriteLine("do you want to continue\n1.yes\n2.no");
    int opt = Convert.ToInt32(Console.ReadLine());
    if (opt == 1)
    {
        continue;
    }
    else if (opt == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }

}