using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PayrollSystem.Core
{
    class PayrollCalculator
    {
        public decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"Calculate salary for employee '{employee.FullName}");
            if (employee.PayItems?.Any() == false)
                return 0;
            var monthTotal = employee.PayItems.Sum(PayItem => PayItem.Value);
            return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2) ;
        }
    }
}
