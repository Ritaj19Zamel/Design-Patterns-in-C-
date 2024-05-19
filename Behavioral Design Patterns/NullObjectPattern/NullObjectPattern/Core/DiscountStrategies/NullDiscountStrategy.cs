using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Core.DiscountStrategies
{
    class NullDiscountStrategy : ICustomerDiscountStrategy
    {
        double ICustomerDiscountStrategy.CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
