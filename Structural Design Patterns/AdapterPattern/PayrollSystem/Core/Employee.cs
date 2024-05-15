using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.Core
{
    class Employee
    {
        public string FullName { get; set; }
        public IEnumerable<PayItem> PayItems { get; set; }
    }
}
