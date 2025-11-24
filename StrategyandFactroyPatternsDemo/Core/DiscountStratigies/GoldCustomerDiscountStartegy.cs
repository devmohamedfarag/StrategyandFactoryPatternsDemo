namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class GoldCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public bool IsAllowed(CustomerCategory customerCategory)
          => customerCategory == CustomerCategory.Gold;
        public double CalculateDiscount(double TotalPrice)
          => TotalPrice >= 10000 ? 0.1 : 0;

    }
}
