using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Core
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;
        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction ? (-1 * _payItem.Value) : _payItem.Value;
    }
}
