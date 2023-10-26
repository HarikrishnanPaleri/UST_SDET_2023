using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Basic_Programs.ExceptionMessages.MyExceptions;

namespace Basic_Programs
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
            int[] num = { 10, 20, 30 };
          //  double result = Num1 / Num2;
          //  Console.WriteLine(result);


            //  int result = Num1 / Num2;
            //   Console.WriteLine(result);

            //foreach (var n in num)
           // {
           //    int result = n / Num2;
             //   Console.WriteLine(result);
          //  }

            for (int i = 0; i <= 3; i++)
            {
              int  result=num[i] / Num2;
                Console.WriteLine(result);
            }
        }

        public void NumCheck()
        { if (Num1 > 100)
            {
                Console.WriteLine("congrats");
            }
            else { //throw new ArgumentException(MyExceptions.exmesslist[3]);
                throw new Number1Exception(MyExceptions.exmesslist[3]);
            }
        }
        public void NumCheck2() { 

        if(Num2<100)
            {
                Console.WriteLine("Congrats");
            }
            else
            {
                throw new NotFiniteNumberException(MyExceptions.exmesslist[2]);
            }
        }

    }
}