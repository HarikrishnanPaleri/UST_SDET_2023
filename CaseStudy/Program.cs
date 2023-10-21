
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






    
  

