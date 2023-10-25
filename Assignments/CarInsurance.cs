using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance:InsurancePolicies
    {
        public CarInsurance(string? policyName, int policyId, double premiumAmount, double price):base(policyName,policyId,premiumAmount)
        {
            Price = price;
        }

        public double Price { get; set; }

        public override double CalculatePremium()
        {
            if(Price>500000)
            {
                PremiumAmount += PremiumAmount * 0.8;
                return PremiumAmount;
            }
            else
            {
                PremiumAmount += PremiumAmount * 0.4;
                return PremiumAmount;
            }
            

        }
    }
}
