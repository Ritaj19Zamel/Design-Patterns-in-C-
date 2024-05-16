using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Core.DiscountStrategies
{
    interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
