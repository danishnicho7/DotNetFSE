# Exercise 3: Sorting Customer Orders

## Scenario:
You are tasked with sorting customer orders by their total price on an e-commerce platform. This helps in prioritizing high-value orders.

## Steps Taken:

### 1. Understand Sorting Algorithms:
- Reviewed several sorting algorithms:
  - **Bubble Sort**: Simple but inefficient for large datasets.
  - **Insertion Sort**: Good for small or nearly sorted data.
  - **Quick Sort**: Efficient and commonly used in practice.
  - **Merge Sort**: Stable and predictable with O(n log n) time.

### 2. Setup:
- Created a class `Order` with attributes:
  - `orderId`
  - `customerName`
  - `totalPrice`

### 3. Implementation:
- Implemented **Bubble Sort** to sort the list of orders by `totalPrice`.
- Implemented **Quick Sort** to perform the same task more efficiently.

### 4. Analysis:
- Time Complexity:
  - Bubble Sort: O(n²)
  - Quick Sort: Average Case O(n log n), Worst Case O(n²)
- Quick Sort is generally preferred over Bubble Sort due to its significantly better performance on average, especially with large datasets.

## Output:
Successfully demonstrated sorting customer orders using both Bubble Sort and Quick Sort. Observed clear performance advantages of Quick Sort, validating its use in real-world applications where sorting efficiency is critical.
![image](https://github.com/user-attachments/assets/aed8ace0-dd8f-47a1-9e2d-2413c5b825ee)

