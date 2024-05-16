using SimpleFactoryPattern.Core;
using SimpleFactoryPattern.Core.DiscountStrategies;
using System;
using System.Linq;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();
            while (true)
            {
                Console.WriteLine("Customer List: [1]Mohamed Ahmed Mohamed [2] Ibrahim Khaled Elnagger");
                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write($"Enter Item Quantity: ");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price: ");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.First(x => x.Id == customerId);
                ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateDiscountStrategy(customer.Category);
                var invoceManager = new InvoiceManager();
                invoceManager.SetDiscountStrategy(customerDiscountStrategy);
                var invoice = invoceManager.CreateInvoice(customer, quantity, unitPrice);
                Console.WriteLine($"Invoice created for customer '{customer.Name}' with net price: {invoice.NetPrice}");
                Console.WriteLine("press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("------------------------------------------");

            }
        }    
    }
}
