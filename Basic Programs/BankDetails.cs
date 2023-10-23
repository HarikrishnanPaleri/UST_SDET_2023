using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetails
    {
        public BankDetails(int custid, long accNo, string? name, string? status)
        {
            Custid = custid;
            AccNo = accNo;
            Name = name;
            Status = status;
      }
        /*

        public BankDetails(int custid, long accNo, string? name)
        {
            Custid = custid;
            AccNo = accNo;
            Name = name;
            Status = "inactive";
        }

        public BankDetails()
        {
            Custid = 879797;
            AccNo = 5768677979;
            Name = string.Empty;
            Status = "inactive";
        }

*/
        public int Custid { get; set; }
        public long AccNo { get; set; }
        public string? Name {  get; set; }
        public string? Status {  get; set; }
      /*  public static void WelcomeMessage ()
        {
            Console.WriteLine("Welcome !!");
        }*/
        public /*override*/virtual void WelcomeMessage()
        {
            Console.WriteLine("Welcome !!");
        }
        public void ExitMessage()
        {
            Console.WriteLine("Done");
        }

        public void GetAccDetails(int custid)
        {
            if (Custid == custid)
                Console.WriteLine("AccNo : {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else
            { Console.WriteLine("AccNO doesnot exise"); }
        }

        public void GetAccDetails(long accNo)
        {
            if (AccNo == accNo)
                Console.WriteLine("AccNo : {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else
            { Console.WriteLine("AccNO doesnot exise"); }
        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("AccNo : {0}\t Name: {1}\t Status: {2}", AccNo, Name, Status);
            else
            { Console.WriteLine("AccNO doesnot exise"); }
        }

       
    }
}
