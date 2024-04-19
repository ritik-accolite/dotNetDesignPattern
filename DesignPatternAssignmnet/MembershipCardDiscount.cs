using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignmnet
{
    internal class MembershipCardDiscount : IDiscount
    {
        private const double DiscountRate = 0.1;  // low Discount i.e 10%
        public double ApplyDiscount(double amount)
        {
            return amount * (1 - DiscountRate);
        }
    }
}
