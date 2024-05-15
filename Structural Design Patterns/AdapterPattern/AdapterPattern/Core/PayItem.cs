using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    class PayItem
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsDeduction { get; set; }
    }
}
