using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Core
{
    class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,
                    Name = "Mohamed Ahmed Mohamed",
                    Category = CustomerCategory.Gold
                },
                new Customer
                {
                    Id = 2,
                    Name = "Ibrahim Khaled Elnagger",
                    Category = CustomerCategory.Silver
                }
            };
        }

    }
}
