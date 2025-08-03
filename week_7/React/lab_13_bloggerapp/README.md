# Lab_13_bloggerapp

## Objective

- Understand and implement various ways of **conditional rendering** in React.
- Learn how to render multiple components conditionally.
- Define and use **List components** in React.
- Explore the importance of **keys** when rendering lists.
- Understand how to extract and manage components using keys.
- Use JavaScript’s `map()` function to dynamically render data in React.

## Goal

The goal of this lab is to build a simple React application named **bloggerapp** that:
- Demonstrates multiple methods of **conditional rendering**
- Contains 3 main components:
  - `BookDetails`
  - `BlogDetails`
  - `CourseDetails`
- Dynamically displays content based on application state or user action.

## Prerequisites

- Node.js installed on your system
- NPM (Node Package Manager)
- Code editor like Visual Studio Code
- Basic understanding of:
  - React functional components
  - React hooks like `useState`
  - Conditional rendering techniques

## Components Used

1. **App.js** – Main application logic and conditional rendering control
2. **BookDetails.js** – Displays information about books
3. **BlogDetails.js** – Displays blog post content
4. **CourseDetails.js** – Displays course-related information

## Uses

- Demonstrates different conditional rendering techniques in React like:
  - `if/else`
  - `ternary operator`
  - `&&` (logical AND operator)
  - Separate render methods inside components
- Introduces list rendering using the `map()` function
- Demonstrates how to use keys efficiently when rendering lists of components

## Output

The app allows toggling between multiple types of content:
- When specific conditions are met (e.g., a button click or a state value), different components are rendered.
- The UI dynamically updates based on which component is selected.
- List data (e.g., list of books or courses) is rendered using the `map()` function.
![output](https://github.com/user-attachments/assets/689ff9c8-998d-4d6f-a112-400d8215b423)
![output1](https://github.com/user-attachments/assets/a99b958f-c2e2-400f-9d61-70f077571f09)

## Conclusion

This lab helps in understanding how **React handles conditional rendering** and how to **manage component-based UIs dynamically**. 


