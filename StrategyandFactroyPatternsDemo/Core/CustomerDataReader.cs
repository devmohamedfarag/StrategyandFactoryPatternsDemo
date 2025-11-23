namespace StrategyandFactroyPatternsDemo.Core
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,
                    Name = "Mohamed Farag",
                    Category =  CustomerCategory.Gold
                },

                new Customer {
                    Id = 2,
                    Name = "Khaled Mostafa",
                    Category = CustomerCategory.Silver
                }
            };
        
        }
    }
}
