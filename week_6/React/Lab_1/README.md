# Lab 1: Creating Your First React App

## Objective
To set up a React environment using `create-react-app` and display a welcome message.

## Steps Followed

1. **Installed Node.js and npm**  
   Downloaded from [https://nodejs.org/en/download/](https://nodejs.org/en/download/)

2. **Enabled PowerShell Script Execution (if blocked)**  
   Opened PowerShell and ran:  
   `Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy RemoteSigned`  
   Selected `Y` to confirm.

3. **Navigated to React Labs Directory**  
   `cd C:\Users\DELL\Desktop\DotNetFSE\week_6\React`

4. **Created React App**  
   `npx create-react-app lab_1`

5. **Moved into App Folder**  
   `cd lab_1`

6. **Opened in VS Code**  
   `code .`

7. **Updated App.js**  
   Replaced contents of `src/App.js` with:

   ```jsx
   import React from 'react';

   function App() {
     return (
       <div>
         <h1>Welcome to the first session of React</h1>
       </div>
     );
   }

   export default App;
   
## Output
![output](https://github.com/user-attachments/assets/8363bd81-c9fe-4f90-b830-a6c73ed65e93)
![output1](https://github.com/user-attachments/assets/ea3563e7-e500-42f9-8d6c-9ad8e902e099)

