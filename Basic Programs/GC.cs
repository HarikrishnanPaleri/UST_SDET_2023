using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC
    {
        public void ListHandling()
        {
            List<int> num = new List<int>();
            num.Add(9);
            num.Add(20);
            num.Add(30);
            //Console.WriteLine(arrayList);
            //   for(int i = 0; i < arrayList.Count; i++)
            //   {
            //      Console.WriteLine(arrayList[i]);
            //  }
            /*
            foreach(var item in arrayList)
              {
                  Console.WriteLine(item);    

              }*/
            num.Add(8);
            num.Add(88);
            num.Add(66);

            num.Reverse();
            foreach (int item in num) { Console.WriteLine(item); }

            //
            //arrayList.Sort();

            num.RemoveAt(3);
            foreach (int item in num)
            { Console.WriteLine(item); }
            Console.WriteLine(num.Contains(10));
            Console.WriteLine(num.IndexOf(20));
        }
        public void Stackhandking()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push("GG");
            st.Push(12.34);
            st.Push(60);
            st.Push(99);
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop" + st.Pop());
            foreach (var item in st)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Peek" + st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }



        }
        public void Queuehandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            //  q.Enqueue(true);
            // q.Enqueue(false);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("pop" + q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Peek" + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
        public void HThandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);
            ht.Add(3, 30);
            //   ht.Add("3", "AA");
            ht.Add(4, "BB");
            foreach (var item in ht)
            { Console.WriteLine(item); }
            ht.Remove(2);

            foreach (var item in ht)
            { Console.WriteLine(item); }
            ht.ContainsKey("6");
            Console.WriteLine(ht.ContainsKey("6"));

            foreach (var item in ht.Values)
            { Console.WriteLine(item); }
            Console.WriteLine("Count" + ht.Count);
        }

        public void SLHandling()
        {
            SortedList sl = new SortedList();
            sl.Add(1, 10);
            // sl.Add(2, "AA");
            sl.Add(3, 30);
            sl.Add(4, 40);
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }
        public void Dicthandling()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "A");
            dt.Add(2, "B");
            dt.Add(3, "C");
            dt.Add(4, "D");
            dt.Add(5, "E");
            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }
            dt.Remove(3);
            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }
        }
    }
}