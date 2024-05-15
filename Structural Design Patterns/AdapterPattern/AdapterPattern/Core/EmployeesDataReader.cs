using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AdapterPattern.Core
{
    class EmployeesDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Ritaj",
                    SecondName = "Wageeh",
                    LastName = "Zamel",
                    PayItems = new List<PayItem>
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Medical Insurance", Value = 150, IsDeduction = true}
                    }
                },
                new Employee
                {
                    FirstName = "Mohammed",
                    SecondName = "Ibrahim",
                    LastName = "Khaled",
                    PayItems = new List<PayItem>
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Medical Insurance", Value = -150}

                    }
                }
            };
        }
    }
}
