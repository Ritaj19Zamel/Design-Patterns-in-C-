using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Core.DiscountStrategies
{
    class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
