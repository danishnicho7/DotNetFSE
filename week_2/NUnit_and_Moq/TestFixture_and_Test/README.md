# TestFixture_and_Test

## Overview
This project demonstrates unit testing practices in C# using the NUnit framework. It focuses on testing a Calculator class by applying core NUnit attributes such as `[TestFixture]`, `[SetUp]`, `[TearDown]`, and `[TestCase]`. The testing logic ensures the arithmetic methods are validated accurately, repeatably, and independently.

## Objective
The objective of this project is to provide a hands-on implementation of unit testing using NUnit. It helps developers:
- Understand NUnit’s test lifecycle.
- Learn how to structure test classes and methods.
- Practice isolating business logic from tests.
- Write parameterized test methods for thorough coverage.

## Goal
The goal is to verify the functionality of a `Calculator` class, specifically the `Add` method, by:
- Instantiating shared test resources using `[SetUp]`.
- Passing multiple input values using `[TestCase]`.
- Comparing actual and expected values using `Assert.That`.
- Ensuring clean test behavior with `[TearDown]`.

## Tasks
- Create a `.NET Framework` class library named `CalcLibrary` with arithmetic operations.
- Create a new test project in the same solution.
- Add a reference to the `CalcLibrary` project in the test project.
- Install necessary NuGet packages:
  - NUnit
  - NUnit3TestAdapter
- Create a test class named `CalculatorTests`.
- Annotate the class and methods with NUnit attributes.
- Write unit test cases using `[TestCase]` for the `Add` method.
- Use `Assert.That(actual, Is.EqualTo(expected))` for validation.

## Output
![image](https://github.com/user-attachments/assets/b6416ed6-1b44-44dd-b2a6-fc1b2eac8206)

