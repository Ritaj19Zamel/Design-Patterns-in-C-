using TemplateMethodPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Core
{
    class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy strategy)
        {
            _customerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                    {
                        new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
                    }
            };
            invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
