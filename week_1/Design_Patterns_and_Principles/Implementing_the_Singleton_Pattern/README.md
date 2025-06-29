# Exercise 1: Implementing the Singleton Pattern

## Scenario:
You need to ensure that a logging utility class in your application has only one instance throughout the application lifecycle to maintain consistent and centralized logging.

## Steps Taken:

### 1. Create a New C# Project:
- Initialized a new **C# Console Application** to implement the Singleton design pattern.

### 2. Define a Singleton Class:
- Created a class named `Logger`.
- Made the constructor **private** to prevent external instantiation.
- Declared a **private static instance** of `Logger` inside the class.
- Added a **public static method** `GetInstance()` to access the singleton instance.

### 3. Implement the Singleton Pattern:
- Ensured the `Logger` class enforces the singleton behavior by:
  - Instantiating the object lazily (only when needed).
  - Returning the same instance on each call to `GetInstance()`.

### 4. Test the Singleton Implementation:
- Created a test class to simulate multiple references to the `Logger` class.
- Verified that all references point to the same instance, confirming that the Singleton pattern was implemented correctly.

## Output:
The Singleton Pattern was successfully implemented in C#. All logging actions use a single shared instance of the `Logger` class, ensuring consistency and preventing multiple log instances from being created during application execution.
![image](https://github.com/user-attachments/assets/abbae951-f9aa-4bd4-b531-469c86c3b221)

