# Lab 12: Ticket Booking App

## Objective
The objective of this lab is to create a simple React application called **`ticketbookingapp`** where:
- Guest users can view flight details.
- Only logged-in users can book tickets.
- The UI dynamically changes based on whether a user is logged in or not.

---

## Goal
- Understand conditional rendering in React.
- Learn how to manage user authentication state (logged in/logged out).
- Practice displaying different components for guest vs authenticated users.

---

##  Prerequisites
Before you begin, ensure you have the following installed:

- [Node.js]
- [npm] or [yarn]
- [VS Code]


---

## Components Used

### 1. `App.js`
- Main component that maintains login state and switches between `GuestPage` and `UserPage`.

### 2. `GuestPage.js`
- Displays:
  - A welcome message: **"Please sign in"**
  - A **Login** button
  - A guest image (optional)

### 3. `UserPage.js`
- Displays:
  - A welcome message: **"Welcome back!"**
  - A **Logout** button
  - A user image (optional)

---

## How to Run the App

1. **Open Terminal in VS Code**  
   Navigate to the  folder.

2. **Create React App**
   
   npx create-react-app ticketbookingapp
   cd ticketbookingapp

## Output
![output](https://github.com/user-attachments/assets/1eed51e1-9f67-47a9-85bb-b35316f0963e)
![output1](https://github.com/user-attachments/assets/6823187f-e83a-4f47-8c1e-f7687ff3e820)
![output2](https://github.com/user-attachments/assets/f804881b-ae2a-4b32-848f-974d589193b3)

## Conclusion
The ticketbookingapp successfully demonstrates the implementation of conditional rendering in React based on user authentication status. By managing state and user interactions, the app provides a clear distinction between guest and logged-in user experiences.
