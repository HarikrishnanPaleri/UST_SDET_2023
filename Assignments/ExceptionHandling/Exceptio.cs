using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionHandling
{
    internal class Exceptio
    {
        public static Dictionary<int, string> exceptionmsg = new Dictionary<int, string>()
 {
     {0,"Patient Name and diagnosis shouldnot be empty or null" },
     {1,"Treatment cost should be positive" },
 };
    }
    internal class InvalidPatientDataException : Exception
        {
            public InvalidPatientDataException(string message) : base(message)
            {



            }
        }
        internal class InvalidMedicalRecordException : Exception
        {
            public InvalidMedicalRecordException(string message) : base(message)

            {


            }



        }



    
}
