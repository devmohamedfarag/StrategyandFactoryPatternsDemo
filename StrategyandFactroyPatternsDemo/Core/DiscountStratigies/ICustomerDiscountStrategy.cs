namespace StrategyandFactroyPatternsDemo.Core.DiscountStratigies
{
    public interface ICustomerDiscountStrategy
    {
        bool IsAllowed(CustomerCategory customerCategory);
        double CalculateDiscount(double TotalPrice);
    }
}
