# Exercise 6: Library Management System

## Scenario:
You are developing a library management system where users can search for books by title or author.

## Steps Taken:

### 1. Understand Search Algorithms:
- Studied the principles of:
  - **Linear Search**: Scans each element in sequence.
  - **Binary Search**: Divides the sorted list in half repeatedly to find the target.
- Identified trade-offs between ease of implementation (linear) and performance (binary).

### 2. Setup:
- Created a class `Book` with the following attributes:
  - `bookId`
  - `title`
  - `author`

### 3. Implementation:
- Implemented **Linear Search**:
  - Traverses the entire list to match the title.
- Implemented **Binary Search**:
  - Requires pre-sorted list based on the title.
  - Uses divide-and-conquer to search efficiently.

### 4. Analysis:
- Time Complexity:
  - Linear Search: O(n)
  - Binary Search: O(log n)
- When to Use:
  - Use **Linear Search** for small or unsorted lists.
  - Use **Binary Search** for large, **sorted** lists where performance is critical.
- Binary search is significantly faster but requires the list to be sorted.

## Output:
Implemented both linear and binary search techniques in the Library Management System. The project demonstrates how search performance varies with data size and sorting, enabling efficient retrieval of books by title or author.
![image](https://github.com/user-attachments/assets/34ef4fd5-3f8b-4d47-9ef6-0c35e46c935c)

