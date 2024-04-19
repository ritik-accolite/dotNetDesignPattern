using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignmnet
{
    public class NoCardDiscount : IDiscount
    {
        public const double DiscountRate = 0; // no discount i.e No Card Discount
        public double ApplyDiscount(double amount)
        {
            return amount - (1- DiscountRate);
        }
    }
}
