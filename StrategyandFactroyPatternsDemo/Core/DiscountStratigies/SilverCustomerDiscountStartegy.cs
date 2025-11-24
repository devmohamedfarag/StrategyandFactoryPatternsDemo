namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class SilverCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public bool IsAllowed(CustomerCategory customerCategory)
          => customerCategory == CustomerCategory.Silver;
        public double CalculateDiscount(double TotalPrice)
           => TotalPrice >= 10000 ? 0.05 : 0;
    }
}
