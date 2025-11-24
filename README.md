 # Strategy & Factory Patterns Demo (C# Console Application):
This project demonstrates how to combine the Strategy Pattern and Factory Pattern and Dependency Injection to build a flexible discount system for customers in a billing/invoice scenario.
The application selects a discount strategy dynamically based on the customer category (New, Silver, Gold).

- Instead of using multiple if/switch statements, the system uses:

✔ Strategy Pattern:
- To encapsulate each discount rule in its own separate class.

✔ Factory Pattern
- To choose which strategy to use based on the customer category.

✔ Dependency Injection
- To register and resolve all strategies automatically using Microsoft.Extensions.DependencyInjection.
---

## Features:
- Implements the Strategy Pattern to encapsulate discount calculation logic.
- Implements the Factory Pattern to create the right strategy for each customer category.
- Generates invoices with:
  - Total price
  - Discount percentage
  - Net price after discount
- Simple interactive Console UI for testing.
- Fully modular and extendable architecture.

---

## Design Patterns Used:
 1) Strategy Pattern:
 - Allows changing the discount calculation logic dynamically at runtime.
  Each discount rule is implemented as:

```csharp
public interface ICustomerDiscountStrategy
{
    bool IsAllowed(CustomerCategory customerCategory);
    double CalculateDiscount(double TotalPrice);
}
```
Concrete strategies:
- NewCustomerDiscountStrategy
- SilverCustomerDiscountStrategy (5% over 10,000)
- GoldCustomerDiscountStrategy (10% over 10,000)
---
 2) Factory Pattern:
   - The Factory selects the correct discount strategy based on the customer’s category:
```csharp
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
```
  - The Factory does NOT calculate discounts — it only chooses the correct strategy.
---
 3) Dependency Injection:
    - The project uses Microsoft.Extensions.DependencyInjection to register all discount strategies at runtime.
      ```csharp
          #region ServiceRegistration 
          var services = new ServiceCollection();

          services.AddTransient<ICustomerDiscountStrategy, SilverCustomerDiscountStartegy>();
          services.AddTransient<ICustomerDiscountStrategy, GoldCustomerDiscountStartegy>();
          services.AddTransient<ICustomerDiscountStrategy, NewCustomerDiscountStartegy>();
          #endregion
      ```
      - DI makes it extremely easy to add new strategies — simply register them.
---

## How the Program Works:
1. User inputs:
   - Customer ID
   - Item quantity
   - Unit price

2. The system:
   - Gets customer data
   - Uses the factory to determine discount strategy
   - Calculates:
       - Total Price
       - Discount %
       - Net Price

---

## Running the Project:
1. **Clone the repository:**
   ```bash
   https://github.com/devmohamedfarag/StrategyandFactoryPatternsDemo.git
2. Open the solution in Visual Studio or VS Code.
3. Run the application:
   ```bash
   dotnet run
