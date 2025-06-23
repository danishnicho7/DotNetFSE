
# Exercise 3: Implementing the Builder Pattern

## Scenario:
You are developing a system to construct complex objects such as a `Computer` with multiple optional components. The Builder Pattern is used to manage the step-by-step construction of these objects while ensuring readability and flexibility.

## Steps Taken:

### 1. Create a New C# Project:
- Initialized a new **C# Console Application** named `BuilderPatternExample`.

### 2. Define a Product Class:
- Created a class named `Computer` with attributes like:
  - `CPU`
  - `RAM`
  - `Storage`
  - `GraphicsCard`
  - `OperatingSystem`

### 3. Implement the Builder Class:
- Defined a **nested `Builder` class** inside `Computer` with chainable methods to set each optional component.
- Implemented a `Build()` method in the Builder that returns a fully configured `Computer` object.

### 4. Implement the Builder Pattern:
- The `Computer` class was given a **private constructor** that accepts a `Builder` object to initialize its fields.
- The builder ensures immutability and clear object construction without overloading constructors.

### 5. Test the Builder Implementation:
- Created a test class to build multiple configurations of `Computer`, such as:
  - A basic office computer.
  - A high-end gaming computer.
- Verified that the object construction was clean, controlled, and scalable using the builder pattern.

## Output:
The Builder Pattern was successfully implemented in C#. It allowed for the creation of `Computer` objects with various configurations in a readable and maintainable way, enhancing clarity and reducing constructor overloading issues.
![image](https://github.com/user-attachments/assets/c2b5aaf6-f4a6-4409-979b-01231225a5d6)
