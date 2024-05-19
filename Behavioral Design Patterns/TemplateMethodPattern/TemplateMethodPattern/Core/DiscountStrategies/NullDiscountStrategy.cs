using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core.DiscountStrategies
{
    class NullDiscountStrategy : ICustomerDiscountStrategy
    {
        double ICustomerDiscountStrategy.CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
