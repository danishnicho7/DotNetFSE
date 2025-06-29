# Exercise 4: Implementing the Adapter Pattern

## Scenario:
You are developing a **payment processing system** that must integrate with **multiple third-party payment gateways**, each offering a different interface. The Adapter Pattern is used to provide a unified interface for the system to interact with all gateways seamlessly.

## Steps Taken:

### 1. Create a New C# Project:
- Initialized a new **C# Console Application** named `AdapterPatternExample`.

### 2. Define Target Interface:
- Created an interface `IPaymentProcessor` with a method:
  - `void ProcessPayment(decimal amount);`

### 3. Implement Adaptee Classes:
- Created classes for third-party payment gateways, such as:
  - `StripeGateway` with a method like `MakeStripePayment(decimal amount)`
  - `PayPalGateway` with a method like `SendPayPalPayment(decimal amount)`

### 4. Implement the Adapter Classes:
- Created adapter classes for each gateway that implement `IPaymentProcessor`:
  - `StripeAdapter` implements `IPaymentProcessor` and wraps around `StripeGateway`.
  - `PayPalAdapter` implements `IPaymentProcessor` and wraps around `PayPalGateway`.
- These adapters translate calls to the expected method in each gateway.

### 5. Test the Adapter Implementation:
- Created a test class to:
  - Instantiate both `StripeAdapter` and `PayPalAdapter`.
  - Call `ProcessPayment()` using the `IPaymentProcessor` interface.
  - Verified that both gateways could be used interchangeably via the common interface.

## Output:
The Adapter Pattern was successfully implemented in C#. The system now supports seamless integration with multiple payment gateways through a unified `IPaymentProcessor` interface, promoting flexibility and scalability without changing core business logic.
![image](https://github.com/user-attachments/assets/51c02721-7fba-4cd7-a224-552a1ab04717)

