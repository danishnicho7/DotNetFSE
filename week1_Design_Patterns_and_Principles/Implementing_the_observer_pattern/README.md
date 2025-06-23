# Exercise 7: Implementing the Observer Pattern

## Scenario:
You are building a **stock market monitoring application** where multiple clients need to be notified in real-time whenever stock prices change. The **Observer Pattern** is used to allow dynamic registration and notification of multiple observers.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `ObserverPatternExample`.

### 2. Define Subject Interface:
- Created an interface `IStock` with methods:
  - `void RegisterObserver(IObserver observer);`
  - `void RemoveObserver(IObserver observer);`
  - `void NotifyObservers();`

### 3. Implement Concrete Subject:
- Implemented a class `StockMarket` that:
  - Maintains a list of registered observers.
  - Holds stock data (e.g., `StockName`, `Price`).
  - Implements the `IStock` interface.
  - Calls `NotifyObservers()` when the price changes.

### 4. Define Observer Interface:
- Created an interface `IObserver` with a method:
  - `void Update(string stockName, decimal price);`

### 5. Implement Concrete Observers:
- Created classes `MobileApp` and `WebApp` that:
  - Implement `IObserver`.
  - React to stock updates by displaying the updated stock information.

### 6. Test the Observer Implementation:
- Demonstrated the system by:
  - Registering instances of `MobileApp` and `WebApp` to a `StockMarket` object.
  - Updating the stock price.
  - Verifying that all observers are notified with the latest price.

## Output:
The **Observer Pattern** was successfully implemented in **C#**, allowing multiple client applications to dynamically subscribe to stock updates. This design promotes loose coupling and real-time communication, making the system extensible and responsive.
![image](https://github.com/user-attachments/assets/f71b39bc-6ce5-461d-8cb4-b1da0e9a463b)

