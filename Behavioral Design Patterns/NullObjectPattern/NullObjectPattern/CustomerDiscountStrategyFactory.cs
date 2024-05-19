using NullObjectPattern.Core;
using NullObjectPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateDiscountStrategy(CustomerCategory category)
        {
            if (category == CustomerCategory.Silver)
               return new SilverCustomerDiscountStrategy();
            else if (category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            else if (category == CustomerCategory.New)
                return new NewCustomerDiscountStrategy();
            return new NullDiscountStrategy();

        }
    }
}
