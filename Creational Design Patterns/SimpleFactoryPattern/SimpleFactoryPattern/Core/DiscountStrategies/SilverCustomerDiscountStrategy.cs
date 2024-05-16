using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Core.DiscountStrategies
{
    class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.05 : 0;
        }
    }
}
