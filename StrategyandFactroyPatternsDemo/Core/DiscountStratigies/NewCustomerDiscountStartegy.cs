namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public class NewCustomerDiscountStartegy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            return 0;
        }
    }
}
