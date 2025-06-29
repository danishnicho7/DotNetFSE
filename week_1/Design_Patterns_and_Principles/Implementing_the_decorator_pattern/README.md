# Exercise 5: Implementing the Decorator Pattern

## Scenario:
You are developing a **notification system** where messages can be sent through multiple channels such as **Email**, **SMS**, and **Slack**. The **Decorator Pattern** is used to dynamically add new notification behaviors without modifying existing code.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `DecoratorPatternExample`.

### 2. Define Component Interface:
- Defined an interface `INotifier` with a method:
  - `void Send(string message);`

### 3. Implement Concrete Component:
- Created a class `EmailNotifier` that implements `INotifier`.
  - The `Send()` method sends a notification via **Email**.

### 4. Implement Decorator Classes:
- Created an **abstract class** `NotifierDecorator` that implements `INotifier` and holds a reference to another `INotifier` object.
- Created concrete decorators:
  - `SMSNotifierDecorator` – adds SMS notification behavior.
  - `SlackNotifierDecorator` – adds Slack notification behavior.
- Each decorator calls the base notifier’s `Send()` method and adds its own logic.

### 5. Test the Decorator Implementation:
- Built a test scenario where:
  - An `EmailNotifier` is wrapped with `SMSNotifierDecorator`, and then with `SlackNotifierDecorator`.
  - A message is sent, demonstrating that all three channels receive the notification in the desired order.

## Output:
The **Decorator Pattern** was successfully implemented using C#. The system now supports dynamically adding notification channels (e.g., Email + SMS + Slack) without modifying the original `Notifier` class. This promotes flexibility and open/closed principle compliance.
![image](https://github.com/user-attachments/assets/63b3cc41-fb47-4e42-acbe-eaadee8ae677)
