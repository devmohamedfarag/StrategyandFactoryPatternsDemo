using StrategyandFactroyPatternsDemo.Core;
using StrategyandFactroyPatternsDemo.Core.DiscountStratigies;

namespace StrategyandFactroyPatternsDemo
{
    public class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
        {
            if (category == CustomerCategory.Silver)
            {
                return new SilverCustomerDiscountStartegy();
            }
            else if (category == CustomerCategory.Gold)
            {
                return new GoldCustomerDiscountStartegy();
            }

            return null;
        }
    }
}
