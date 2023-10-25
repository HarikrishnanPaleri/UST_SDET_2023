using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicies
    {
        public LifeInsurance(string? policyName, int policyId, double premiumAmount, int age):base(policyName,policyId,premiumAmount)
        {
            Age = age;
        }

        public int Age { get; set; }
        public override double CalculatePremium()
        {
            if(Age>60)
            {
                PremiumAmount += PremiumAmount * 0.6;
                return PremiumAmount;
            }
            else
            {
                PremiumAmount = PremiumAmount;
                return PremiumAmount;   
            }
        }
        
    }
}
