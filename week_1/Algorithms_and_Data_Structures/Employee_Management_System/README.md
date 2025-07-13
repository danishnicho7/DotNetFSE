# Exercise 4: Employee Management System

## Scenario:
You are developing an employee management system for a company. Efficiently managing employee records is crucial.

## Steps Taken:

### 1. Understand Array Representation:
- Explained how arrays are stored in contiguous memory locations.
- Highlighted advantages of arrays:
  - Fast element access using index (O(1)).
  - Efficient traversal for fixed-size data.
  
### 2. Setup:
- Created a class `Employee` with the following attributes:
  - `employeeId`
  - `name`
  - `position`
  - `salary`

### 3. Implementation:
- Used a fixed-size array to store `Employee` objects.
- Implemented methods for:
  - **Add**: Insert employee into the array.
  - **Search**: Find an employee by `employeeId`.
  - **Traverse**: Display all employees.
  - **Delete**: Remove an employee from the array by shifting elements.

### 4. Analysis:
- Time Complexity:
  - Add: O(1) (if space is available), O(n) (if resizing or shifting needed)
  - Search: O(n)
  - Traverse: O(n)
  - Delete: O(n) (due to shifting)
- Limitations of Arrays:
  - Fixed size — cannot dynamically grow.
  - Inefficient insert/delete operations for large datasets.
- Arrays are suitable for small, predictable datasets where quick indexed access is required.

## Output:
Developed a basic employee management system using arrays. Demonstrated core array operations and discussed their efficiencies and limitations in the context of real-world applications.
![image](https://github.com/user-attachments/assets/938c97e9-51f8-47da-83a9-6e41e99ddd9a)

