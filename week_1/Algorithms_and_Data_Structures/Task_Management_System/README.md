# Exercise 5: Task Management System

## Scenario:
You are developing a task management system where tasks need to be added, deleted, and traversed efficiently.

## Steps Taken:

### 1. Understand Linked Lists:
- Studied the types of linked lists:
  - **Singly Linked List**: Each node points to the next.
  - **Doubly Linked List**: Each node points to both the next and previous nodes.
- Identified that a singly linked list is sufficient for basic task operations.

### 2. Setup:
- Created a class `Task` with the following attributes:
  - `taskId`
  - `taskName`
  - `status`

### 3. Implementation:
- Built a custom **Singly Linked List** to manage tasks dynamically.
- Implemented methods for:
  - **Add**: Insert a new task node at the end of the list.
  - **Search**: Find a task by its `taskId`.
  - **Traverse**: Display all tasks.
  - **Delete**: Remove a task by adjusting node links.

### 4. Analysis:
- Time Complexity:
  - Add: O(n) (to insert at end)
  - Search: O(n)
  - Traverse: O(n)
  - Delete: O(n)
- Advantages of Linked Lists over Arrays:
  - Dynamic size — no need to predefine the size.
  - Efficient insertions and deletions compared to arrays (especially at the beginning or middle).
  - Better suited for applications where memory allocation changes frequently.

## Output:
Successfully implemented a task management system using a singly linked list. Demonstrated dynamic task handling and efficient traversal, making the system flexible and scalable for future extensions.
![image](https://github.com/user-attachments/assets/00509138-8c55-4eaf-8a6e-f75b2798a78a)

