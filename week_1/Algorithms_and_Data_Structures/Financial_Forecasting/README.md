# Exercise 7: Financial Forecasting

## Scenario:
You are developing a financial forecasting tool that predicts future values based on past data.

## Steps Taken:

### 1. Understand Recursive Algorithms:
- Studied the concept of **recursion**, where a function calls itself to solve smaller subproblems.
- Recognized how recursion can simplify logic in problems involving repeated patterns, such as forecasting future values.

### 2. Setup:
- Created a method to calculate future financial values recursively.
- Defined necessary parameters such as:
  - Initial value
  - Growth rate
  - Number of periods

### 3. Implementation:
- Implemented a **recursive algorithm** to forecast future values.
- Formula used:
- FutureValue(n) = FutureValue(n - 1) * (1 + growthRate)
- Base case established to prevent infinite recursion:
- When `n == 0`, return the initial value.

### 4. Analysis:
- **Time Complexity**: O(n), where `n` is the number of periods.
- Identified inefficiencies due to repeated calls in recursion.
- Suggested **memoization** or **iterative approaches** as optimization strategies to reduce redundant computations.

## Output:
A recursive forecasting tool was successfully implemented, providing a clear view of how past data can be used to predict future financial trends. Optimization techniques were discussed to ensure performance is scalable for longer forecasting periods.
![image](https://github.com/user-attachments/assets/77368b12-35f3-4255-bc8e-24fdfad05ab9)


