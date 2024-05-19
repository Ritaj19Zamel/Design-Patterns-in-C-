using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core.DiscountStrategies
{
    class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
