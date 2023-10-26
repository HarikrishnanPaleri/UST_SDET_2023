using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callId, double phoneNumber, double callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }
        public double PhoneNumber { get; set; }
        public double CallTime {  get; set; }
    }
}
