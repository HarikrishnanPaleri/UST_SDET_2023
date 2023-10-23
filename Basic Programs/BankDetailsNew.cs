using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custid, long accNo, string? name, string? status) : base(custid, accNo, name, status)
        {
        }
     /*   public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0}!!",Name);
        }*/
        public override void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0}!!", Name);
        }
    }
}
