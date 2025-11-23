namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double TotalPrice);
    }
}
