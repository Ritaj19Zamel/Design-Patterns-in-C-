using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern.Core.DiscountStrategies
{
    interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
