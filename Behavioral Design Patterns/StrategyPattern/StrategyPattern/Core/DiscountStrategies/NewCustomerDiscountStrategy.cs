using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Core.DiscountStrategies
{
    class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
