using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core
{
    class InvoiceLine
    {
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
