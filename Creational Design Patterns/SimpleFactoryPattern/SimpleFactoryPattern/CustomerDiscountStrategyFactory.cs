using SimpleFactoryPattern.Core;
using SimpleFactoryPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateDiscountStrategy(CustomerCategory category)
        {
            if (category == CustomerCategory.Silver)
               return new SilverCustomerDiscountStrategy();
            else if (category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            else
                return new NewCustomerDiscountStrategy();
            return null;

        }
    }
}
