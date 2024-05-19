using System;
using System.Linq;
using TemplateMethodPattern.Core;
using TemplateMethodPattern.Core.DiscountStrategies;
using TemplateMethodPattern.ShoppingCart;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new CustomerDataReader().GetCustomers();
            var items = new ItemDataReader().GetItems();
            while (true)
            {
                Console.WriteLine("Customer List: ");
                foreach (var customer in customers)
                    Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");
                Console.WriteLine();

                Console.WriteLine("Item List: ");
                foreach (var item in items)
                    Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice:0.00})");
                Console.WriteLine();

                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write($"Select shopping Cart Type (Online | InStore): ");
                var cartType = Console.ReadLine();
                TemplateMethodPattern.ShoppingCart.ShoppingCart shoppingCart;

                if (cartType.Equals("Online", StringComparison.OrdinalIgnoreCase))
                {
                    shoppingCart = new OnlineShoppingCart();
                }
                else
                {
                    shoppingCart = new InStoreShoppingCart();
                }
                while (true)
                {
                    Console.Write($"Enter Item ID (0 to complete the order): ");
                    var itemId = int.Parse(Console.ReadLine());
                    if (itemId == 0)
                        break;
                    Console.Write($"Enter Item Quantity: ");
                    var quantity = double.Parse(Console.ReadLine());
                    var item = items.First(x => x.Id == itemId);
                    shoppingCart.AddItem(itemId, quantity, item.UnitPrice);
                }


                var selectedCustomer = customers.First(x => x.Id == customerId);
                // ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateDiscountStrategy(selectedCustomer.Category);
                // var invoceManager = new InvoiceManager();
                // invoceManager.SetDiscountStrategy(customerDiscountStrategy);
                // var invoice = invoceManager.CreateInvoice(selectedCustomer, quantity, unitPrice);
                //Console.WriteLine($"Invoice created for customer '{selectedCustomer.Name}' with net price: {invoice.NetPrice}");
                shoppingCart.CheckOut(selectedCustomer);
                Console.WriteLine("press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("------------------------------------------");

            }
        }
    }
}
