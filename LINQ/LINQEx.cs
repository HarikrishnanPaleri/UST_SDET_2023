using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("c Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("JAVA Tutorial");
            courses.Add("DBMS");
            courses.Add("UI Exp");

            /*   var result = from c in courses where c.Equals("DBMS")
                            select c;

               foreach (var r in result)
               {
                   Console.WriteLine(r);
               }
               Console.WriteLine(result.);
            */

            //  var result = courses.Where(c => c.Equals("DBMS"));
            var result = courses.Where(c => c.Contains("Tutorial"));

            foreach (var q in result) 
            {
            Console.WriteLine(q);
            
            }
        }
        public void eg2() 
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "adithyan", "lkg"));
            students.Add(new Student(2, "abhinand", "anganavadi"));
            students.Add(new Student(3, "Franklin", "Principal"));
            students.Add(new Student(4, "Deepal", "2B"));

            var stud = students.Where(q=>q.Id == 2);
            foreach (var q in stud) 
            {
                Console.WriteLine(q.Id +" "+ q.Name+" "+q.Department);
            
            }
            var stud1 = students.Where(p => p.Name == "adithyan");
            foreach (var p in stud1)
            {
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Department);

            }
            Student st = (Student)students.FirstOrDefault(s => s.Id == 3);
            if (st != null)
            {
                Console.WriteLine(st.Id + " " + st.Name + " " + st.Department);
            }
            else
            {
                Console.WriteLine("nf");
            }

            
            List<Student> students10 = (List<Student>)students.FindAll(s => s.Name == "adithyan" || s.Name == "abhinand");
            foreach(var item in students10)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Department);
            }
            Console.WriteLine(">=5");

            List<Student> students11 = (List<Student>)students.FindAll(s => s.Id>=3);
            foreach (var item in students11)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Department);
            }

            

        }

        public void filteringofType()
        {
            ArrayList elements  = new ArrayList();
            elements.Add(1);
            elements.Add(2);
            elements.Add("hari");
            elements.Add("Adhi");
            var numbers = elements.OfType<int>();
            var strings = elements.OfType<string>();
            foreach(string str in strings) 
            {
                Console.WriteLine("string:" + str);
            }

            foreach (int num in numbers)
                Console.WriteLine("Integer:" + num);

           
        }

        public void SortOrderBy()
        {
            List<Student>st = new List<Student>();
            st.Add(new Student(1, "abhi", "don"));
            st.Add(new Student(3, "adithyan", "fun"));
            st.Add(new Student(2, "franklin", "phone"));
            /*
            var result = st.OrderBy(s =>s.Id).ThenBy(s=>s.Department);
            foreach (var item in result)
            {
                Console.WriteLine(item.Id+" "+item.Name + " " + item.Department);
            }
            */
            var resu = st.ToLookup(s => s.Name);
            foreach(var item in resu)
            {
                Console.WriteLine(item.Key);
                foreach(var item2 in item)
                {
                    Console.WriteLine(item2.Id+" "+item2.Department);
                }

            }
        }
        
        
        
    }
}
