# Exercise 1: Ranking and Window Functions

## Goal
Demonstrate the usage of SQL window functions — `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()` — along with `OVER()` and `PARTITION BY` to rank products within their categories.

---

## Scenario
Given a list of products with categories and prices, we want to identify the **top 3 most expensive products in each category** using different ranking strategies.

---

## SQL Features Used

- `ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC)`
- `RANK() OVER(PARTITION BY Category ORDER BY Price DESC)`
- `DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC)`

Each of these functions helps in understanding **how ties are handled** within groups (categories).

---

## Steps Taken

1. Created a sample `Products` table with columns: `ProductID`, `ProductName`, `Category`, `Price`.
2. Applied three window functions (`ROW_NUMBER`, `RANK`, `DENSE_RANK`) with the clause:
   ```sql
   OVER(PARTITION BY Category ORDER BY Price DESC)

## Output
![output_row_number](https://github.com/user-attachments/assets/97081282-51d3-46dd-b81d-77ecccbb820e)

![output_rank](https://github.com/user-attachments/assets/8e7e1005-aa6c-466e-b18f-e8d304b8dc77)

![output_dense_rank](https://github.com/user-attachments/assets/fcd3baee-aa25-404c-8af7-d8a57ee7d0df)

