 # Strategy & Factory Patterns Demo (C# Console Application):

This project demonstrates how to combine the Strategy Pattern and Factory Pattern to build a flexible discount system for customers in a billing/invoice scenario.
The application selects a discount strategy dynamically based on the customer category (New, Silver, Gold).

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
    double CalculateDiscount(double TotalPrice);
}
```
Concrete strategies:
- NewCustomerDiscountStrategy
- SilverCustomerDiscountStrategy (5% over 10,000)
- GoldCustomerDiscountStrategy (10% over 10,000)
---
 2) Factory Pattern:
   - Used to select and instantiate the right strategy:
```csharp
public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
{
    if (category == CustomerCategory.Silver)
        return new SilverCustomerDiscountStrategy();

     else if (category == CustomerCategory.Gold)
        return new GoldCustomerDiscountStrategy();

    return new NewCustomerDiscountStrategy();
}
```
  - This ensures the main program never knows how strategies are created.

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
