using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal  class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName {  get; set; }
        public int PolicyId {  get; set; }
        public double PremiumAmount {  get; set; }

        public double RenewPolicy(double newPremium)
        {
            newPremium = PremiumAmount;
           
         Console.WriteLine("Premium is :{0}",PremiumAmount);
            return newPremium;
        }
        public double RenewPolicy()
        {
            PremiumAmount += (PremiumAmount * 0.1);
            Console.WriteLine("Premium amount updated by 10% & the new premium amount is :{0}",PremiumAmount);
            return PremiumAmount;
        }
       
    }
}
