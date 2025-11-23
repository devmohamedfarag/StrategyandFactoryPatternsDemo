using StrategyandFactroyPatternsDemo;
using StrategyandFactroyPatternsDemo.Core;
using StrategyandFactroyPatternsDemo.Core.DiscountStratigies;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();

while (true)
{
    Console.WriteLine("Customer List: 1) Mohamed Farag 2) Khaled Mostafa");

    Console.Write($"Enter Customer Id: ");
    var customerId = int.Parse(Console.ReadLine());

    Console.Write($"Enter Item Quantity: ");
    var quantity = int.Parse(Console.ReadLine());

    Console.Write($"Enter Unit Price: ");
    var unitPrice = int.Parse(Console.ReadLine());

    var customer = customers.First(x => x.Id == customerId);

    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.Category);

    var invoiceManager = new InvoiceManager();
    invoiceManager.SetCustomerStrategy(customerDiscountStrategy);

    var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);  

    Console.WriteLine($"Invoice Created for customer {customer.Name} with net price: {invoice.NetOrice}");
    Console.WriteLine("Press any key tp create another invoice");
    Console.ReadKey();
    Console.WriteLine("-----------------------------------");
}