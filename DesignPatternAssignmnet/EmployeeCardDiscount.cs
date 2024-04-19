using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignmnet
{
    public class EmployeeCardDiscount : IDiscount
    {
        public const double DiscountRate = 0.2; // high discount i.e 20%
        public double ApplyDiscount(double amount)
        {
            return amount * (1 - DiscountRate);
        }
    }
}
