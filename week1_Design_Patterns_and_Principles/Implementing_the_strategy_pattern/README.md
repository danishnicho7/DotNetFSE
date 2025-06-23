# Exercise 8: Implementing the Strategy Pattern

## Scenario:
You are developing a **payment system** where users can choose from different payment methods (e.g., Credit Card, PayPal) at runtime. The **Strategy Pattern** is used to encapsulate payment algorithms and allow flexible switching between them.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `StrategyPatternExample`.

### 2. Define Strategy Interface:
- Defined an interface `IPaymentStrategy` with a method:
  - `void Pay(decimal amount);`

### 3. Implement Concrete Strategies:
- Created classes that implement the `IPaymentStrategy` interface:
  - `CreditCardPayment` for processing payments via credit card.
  - `PayPalPayment` for handling PayPal transactions.

### 4. Implement Context Class:
- Created a class `PaymentContext` that:
  - Contains a private reference to `IPaymentStrategy`.
  - Has a method `SetPaymentStrategy(IPaymentStrategy strategy)` to change the strategy at runtime.
  - Has a method `ExecutePayment(decimal amount)` that delegates the call to the selected strategy.

### 5. Test the Strategy Implementation:
- Demonstrated the system by:
  - Creating a `PaymentContext` object.
  - Switching between `CreditCardPayment` and `PayPalPayment` strategies.
  - Processing payments using different strategies dynamically.

## Output:
The **Strategy Pattern** was effectively implemented in **C#**, enabling runtime selection of payment methods. This approach supports open/closed principles, allowing new payment methods to be added with minimal changes to the core system.
![image](https://github.com/user-attachments/assets/bcb87473-a3f1-48b3-9b74-33d80b74e421)
