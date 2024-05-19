using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    class InStoreShoppingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {
        }
    }
}