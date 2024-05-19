using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Core.DiscountStrategies
{
    class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.1 : 0;
        }
    }
}
