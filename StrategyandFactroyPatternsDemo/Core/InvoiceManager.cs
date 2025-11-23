using StrategyandFactroyPatternsDemo.Core.DiscountStratigies;

namespace StrategyandFactroyPatternsDemo.Core
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _CustomerDiscountStrategy;

        public void SetCustomerStrategy(ICustomerDiscountStrategy strategy)
        {
            _CustomerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                {
                   new InvoiceLine {Quantity = quantity, UnitPrice = unitPrice}
                }
            };
            invoice.DiscountPercentage = _CustomerDiscountStrategy.CalculateDiscount(invoice.TotalPrice); 
            return invoice;
        }
    }
}
