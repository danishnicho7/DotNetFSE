## Lab: 4 – Blog App (Component Lifecycle in React)

### Objective
To demonstrate the use of component lifecycle methods in React (componentDidMount and componentDidCatch) by building a simple blog app that fetches and displays blog posts from an API.

### Method Used
 #### React Class Components

#### Lifecycle Methods:

   componentDidMount() – Fetch blog data when the component is mounted.
   
   componentDidCatch() – Handle errors gracefully if any issue occurs during rendering.

#### State Management

#### Fetch API

### Explanation:
A class component BlogApp is created which uses componentDidMount() to fetch data and stores it in the state.

The fetched data is passed to a child component PostList to render the list of blog posts.

If there’s any error while rendering, componentDidCatch() method will catch it and display a fallback UI with the message: “Something went wrong while displaying posts.”

### How to Run

Open terminal

Navigate to the project folder:
cd lab_4_blogapp

Install dependencies:
npm install

Start the app:
npm start

The app will open in the browser and display blog posts.

### Output
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/8d0564c9-b8c9-4fb3-bf2b-a902f3076b32" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/7d88432e-6768-4b05-92f9-39f8582b3f32" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/9654982f-eea4-4212-9980-c174300d63f8" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/6fbc37e7-2f28-4039-a553-20968115d47c" />
