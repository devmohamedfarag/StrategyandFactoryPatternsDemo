namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class GoldCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            return TotalPrice >= 10000? 0.1 : 0;
        }
    }
}
