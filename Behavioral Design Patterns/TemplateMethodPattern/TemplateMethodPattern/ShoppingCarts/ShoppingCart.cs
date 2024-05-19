using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    abstract class ShoppingCart
    {
        private List<InvoiceLine> _lines = new List<InvoiceLine>();
        public void AddItem(int itemId, double quantity, double unitPrice)
        {
            _lines.Add(new InvoiceLine
            {
                ItemId = itemId,
                Quantity = quantity,
                UnitPrice = unitPrice
            });
        }
        public void CheckOut(Customer customer)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = _lines
            };
            //Step one
            ApplyTaxes(invoice);
            //Step Two
            ApplyDiscount(invoice);
            //Step Three
            ProcessPayment(invoice);
        }
        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * 0.15;
        }
        //template method
        protected abstract void ApplyDiscount(Invoice invoice);

        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice created for customer '{invoice.Customer.Name}' with net price {invoice.NetPrice}");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}