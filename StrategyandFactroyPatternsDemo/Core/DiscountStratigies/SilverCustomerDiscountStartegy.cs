namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class SilverCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            return TotalPrice >= 10000 ? 0.05 : 0;
        }
    }
}
