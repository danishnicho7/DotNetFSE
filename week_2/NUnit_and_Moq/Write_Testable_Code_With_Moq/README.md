# Write Testable Code with Moq

## Introduction

This project demonstrates the principles of writing testable code in C# using the concepts of dependency injection and mocking. The focus is on isolating external dependencies—such as SMTP mail servers—to create reliable, fast, and repeatable unit tests using the Moq and NUnit frameworks.

## Objective

The core objective of this exercise is to test a component responsible for sending emails to customers, without actually sending real emails. This is achieved by abstracting the mail sending functionality behind an interface and using a mock implementation during unit testing. By doing so, we ensure that the unit test remains isolated from the external world and tests only the business logic in question.

## Problem Scenario

In real-world applications, components often depend on external services like SMTP servers, databases, APIs, or file systems. Testing such components directly can be:
- Slow
- Error-prone
- Difficult to automate
- Dependent on external configurations

To overcome this, we follow a design approach that allows replacing real dependencies with test-friendly versions, or **mocks**, during testing.

## Tasks / Implementation Steps

1. **Create the Main Class Library**
   - Set up a new Class Library project named `CustomerCommLib`.
   - Create an interface `IMailSender` with a method to send an email.
   - Implement this interface in a class named `MailSender`, which contains actual SMTP mail-sending logic.

2. **Write a Testable Class**
   - Create a class `CustomerComm` that depends on `IMailSender`.
   - Inject the dependency via the constructor to allow substitution during testing.
   - Use this class to implement logic for sending customer notification emails.

3. **Create the Test Project**
   - Set up a separate Class Library project named `CustomerComm.Tests`.
   - Add NUnit and Moq packages via NuGet.
   - Add a reference to the `CustomerCommLib` project.

4. **Write Unit Tests with Moq and NUnit**
   - Create a test class and annotate it with `[TestFixture]`.
   - Use Moq to create a mock of the `IMailSender` interface.
   - Set up the mock to return `true` when the email sending method is called.
   - Use NUnit's `[Test]` attribute to validate the behavior of `CustomerComm.SendMailToCustomer()` using assertions.

5. **Build and Execute**
   - Build the solution to verify successful compilation.
   - Use a test runner to execute the unit tests and ensure the logic behaves as expected under mocked conditions.

## Tools and Technologies Used

- **C# / .NET:** The programming language and runtime used for developing the library and test projects.
- **NUnit:** A widely used testing framework for writing and running unit tests in .NET.
- **Moq:** A powerful mocking library that allows developers to simulate the behavior of dependencies and verify interactions.
- **Visual Studio / Visual Studio Code:** The integrated development environments used to build and manage the projects.
- **Git / GitHub:** For version control and collaboration.


## Output
![image](https://github.com/user-attachments/assets/49c1d5a6-3bb6-404d-a4f8-da6c76187ab2)
![image](https://github.com/user-attachments/assets/3b7ae2c1-9223-49fb-9213-c9d51b6816cd)
![image](https://github.com/user-attachments/assets/18bf2f23-f9d6-4a9c-acba-ea3e0c074418)
