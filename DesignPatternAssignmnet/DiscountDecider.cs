using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignmnet
{
    public class DiscountDecider
    {
        private IDiscount _discount;
        public DiscountDecider(IDiscount discount)
        {
            _discount = discount;
        }
        public double Checkout(double amount)
        {
            return _discount.ApplyDiscount(amount);
        }
    }
}

