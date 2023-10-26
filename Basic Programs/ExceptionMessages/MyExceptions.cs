using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        /*ublic static List<string> exmesslist = new List<string>()
           {"Dont give 0 for denominator",
            "Indx is out of range",
           "Unknown Exception"

        };
        */
        public static Dictionary<int, string> exmesslist = new Dictionary<int, string>()
        {
            {0,"dont give zero for denominator" },
            {1,"index is out of range" },
            {2,"unknown exception" },
            {3,"not hundred" },
            {4,"Age is more" }

        };
        internal class Number1Exception : Exception
        {
            public Number1Exception(string message) : base(message)
            {
            
            
            
            }
        }

        internal class Number2Exception : Exception 
        {
            public Number2Exception(string message) : base(message) 
            
            {
            
            
            }
        
        
        
        }
}
}