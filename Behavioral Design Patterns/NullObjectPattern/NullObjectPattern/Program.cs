using NullObjectPattern.Core;
using NullObjectPattern.Core.DiscountStrategies;
using System;
using System.Linq;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();
            while (true)
            {
                Console.WriteLine("Customer List: ");
                foreach (var customer in customers)
                    Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");
                Console.WriteLine();
                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write($"Enter Item Quantity: ");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price: ");
                var unitPrice = double.Parse(Console.ReadLine());

                var selectedCustomer = customers.First(x => x.Id == customerId);
                ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateDiscountStrategy(selectedCustomer.Category);
                var invoceManager = new InvoiceManager();
                invoceManager.SetDiscountStrategy(customerDiscountStrategy);
                var invoice = invoceManager.CreateInvoice(selectedCustomer, quantity, unitPrice);
                Console.WriteLine($"Invoice created for customer '{selectedCustomer.Name}' with net price: {invoice.NetPrice}");
                Console.WriteLine("press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("------------------------------------------");

            }
        }
    }
}
