using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArraysEx
    {
        //int[] numbers = {10, 20, 30};   
       readonly int[] numbers = new int[5];
        public void Onedim()
        {
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("2nd");
           // numbers = new int[5];
            numbers[1] = 123;
           // for (int i = 0; i < numbers.Length; i++)
           // {
           //     Console.WriteLine(numbers[i]);
           // }
           Array.Sort(numbers);
           foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
           Array.Clear(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        public void Twodim()
        {
            int[,] nums = { { 100, 200 },{300,400} };

            // nums[0,0] = 1;
            // nums[0,1] = 2;
            // nums[1,0] = 3;
            // nums[1,1] = 4;


            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        
        }
        public void Ja()
        {
            int[][,] arr = new int[][,]
            {


                new int[,] { { 1, 2 }, { 3,4} },
                new int[,] { { 4,5}, { 5,6},{ 7,8} },
                new int[,] { { 7, 8, 9 }, { 8, 9, 10}, { 9, 10, 11} },
                new int[,] { { 9, 10 }, { 10, 11}, {  11, 12} }


            };

          //  foreach (var item in arr)
            //{
            //    Console.WriteLine(item[1,1]);
           // }

            for (int i =0; i< arr.Length; i++)
            {
                int x = 0;
                for(int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for(int k = 0; k < arr[j].Rank;k++)
                    {
                        Console.Write(arr[i][j, k] + " ");

                    }
                    Console.WriteLine();

                }
                x++;
                Console.WriteLine();
            }




        }

    }
}
