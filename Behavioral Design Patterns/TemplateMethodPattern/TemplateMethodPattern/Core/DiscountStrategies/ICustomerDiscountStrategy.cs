using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core.DiscountStrategies
{
    interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
