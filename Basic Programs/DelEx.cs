using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class DelEx
    {
       

        public static void MethodA()
        {
            Console.WriteLine("Adithyan is a fun guy");
        }
        public static void MethodB(string msg)
        {
            Console.WriteLine(msg);
        }

        public int Num1 {  get; set; }
        public int Num2 { get; set; }

        public void Add(int num1, int num2)
        {

            Num1 = num1;
            Num2 = num2;
            Console.WriteLine(Num1 + Num2);
        }
            public void sub(int num1, int num2)
            {

                Num1 = num1;
                Num2 = num2;
                Console.WriteLine(Num1 - Num2);
            }
        public int Add1(int num1, int num2)
        {

            Num1 = num1;
            Num2 = num2;
           return(Num1+Num2 );
        }

    }
}
