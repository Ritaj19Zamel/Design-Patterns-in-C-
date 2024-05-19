using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    class OnlineShoppingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {
            if (invoice.TotalPrice >= 100000)
            {
                invoice.DiscountPercentage = 0.05;
            }
        }
    }
}