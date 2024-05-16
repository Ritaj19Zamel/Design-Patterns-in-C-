using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Core.DiscountStrategies
{
    interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
