using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Core
{
    public class PayrollSystemPayItemEmployeeAdapter
    {
        private readonly Employee _employee;
        private readonly IEnumerable<PayrollSystemPayItemAdapter> _payItems;
        public PayrollSystemPayItemEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(PayItem => new PayrollSystemPayItemAdapter(payItem)).ToList();
        }
        public string FullName => _employee.FullName;
        public IEnumerable<PayrollSystemPayItemAdapter> PayItems => _payItems;
    }
}
