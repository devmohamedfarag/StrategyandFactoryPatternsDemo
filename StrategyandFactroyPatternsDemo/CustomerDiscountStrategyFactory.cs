using Microsoft.Extensions.DependencyInjection;
using StrategyandFactroyPatternsDemo.Core;
using StrategyandFactroyPatternsDemo.Core.DiscountStratigies;

namespace StrategyandFactroyPatternsDemo
{
    public class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
        {
            #region ServiceRegistration 
            var services = new ServiceCollection();

            services.AddTransient<ICustomerDiscountStrategy, SilverCustomerDiscountStartegy>();
            services.AddTransient<ICustomerDiscountStrategy, GoldCustomerDiscountStartegy>();
            services.AddTransient<ICustomerDiscountStrategy, NewCustomerDiscountStartegy>();
            #endregion

            var serviceProvider = services.BuildServiceProvider();
            IEnumerable<ICustomerDiscountStrategy> strategies = serviceProvider.GetServices<ICustomerDiscountStrategy>();

            return strategies.FirstOrDefault(s => s.IsAllowed(category));
        }
    }
}
