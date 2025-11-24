namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class NewCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public bool IsAllowed(CustomerCategory customerCategory)
          => customerCategory == CustomerCategory.New;
        public double CalculateDiscount(double TotalPrice)
        {
            return 0;
        }
    }
}
