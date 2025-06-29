# Exercise 1: Inventory Management System

## Scenario:
You are developing an inventory management system for a warehouse. Efficient data storage and retrieval are crucial.

## Steps Taken:

### 1. Understand the Problem:
- Explained the importance of data structures and algorithms in handling large inventories.
- Discussed suitable data structures such as `ArrayList` and `HashMap` for managing inventory data.

### 2. Setup:
- Created a new project for the Inventory Management System.

### 3. Implementation:
- Defined a `Product` class with the following attributes:
  - `productId`
  - `productName`
  - `quantity`
  - `price`
- Chose a suitable data structure (`ArrayList` or `HashMap`) to store product data.
- Implemented core methods to:
  - Add products to the inventory
  - Update product details
  - Delete products from the inventory

### 4. Analysis:
- Analyzed the **time complexity** for each operation:
  - Add: O(1) for `HashMap`, O(n) for `ArrayList` if duplicates must be checked.
  - Update: O(1) for `HashMap`, O(n) for `ArrayList`.
  - Delete: O(1) for `HashMap`, O(n) for `ArrayList`.
- Discussed optimization strategies such as using hashing for faster lookups, and indexing for efficient data access.

- ##Output
- ![image](https://github.com/user-attachments/assets/ca901462-65b9-4b3d-96ed-57bca7dd0e61)



      
