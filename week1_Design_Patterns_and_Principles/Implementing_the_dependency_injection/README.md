# Exercise 11: Implementing Dependency Injection

## Scenario:
You are developing a **customer management application** where the `CustomerService` class depends on a `CustomerRepository` to retrieve data. You will use **Dependency Injection (DI)** to manage this dependency, promoting loose coupling and better testability.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `DependencyInjectionExample`.

### 2. Define Repository Interface:
- Created an interface `ICustomerRepository` with a method:
  - `Customer FindCustomerById(int id);`

### 3. Implement Concrete Repository:
- Created a class `CustomerRepository` that implements `ICustomerRepository`.
- This class simulates data access by returning dummy `Customer` data.

### 4. Define Service Class:
- Created a class `CustomerService` with the following:
  - A private readonly field of type `ICustomerRepository`.
  - A constructor that accepts `ICustomerRepository` as a parameter.
  - A method `GetCustomer(int id)` that uses the repository to fetch customer data.

### 5. Implement Dependency Injection:
- Used **constructor injection** to inject the dependency (`ICustomerRepository`) into `CustomerService`.

### 6. Test the Dependency Injection Implementation:
- In the `Main` method:
  - Created an instance of `CustomerRepository`.
  - Injected it into the constructor of `CustomerService`.
  - Called `GetCustomer(id)` and displayed the result.

## Output:
The **Dependency Injection Pattern** was successfully implemented in **C#**, decoupling the service from the data layer. This makes the application:
- Easier to maintain
- More flexible for testing (e.g., using mock repositories)
- Aligned with SOLID principles, especially the **Dependency Inversion Principle (D)**.

![image](https://github.com/user-attachments/assets/42283b99-7f0d-4ff4-8d67-2e8996d981a6)
