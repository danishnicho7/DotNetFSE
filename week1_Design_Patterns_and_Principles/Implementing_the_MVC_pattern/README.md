# Exercise 10: Implementing the MVC Pattern

## Scenario:
You are developing a **simple web application** to manage student records using the **Model-View-Controller (MVC)** design pattern. This architecture helps separate concerns, making the code easier to maintain and scale.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** (or MVC Web Application) named `MVCPatternExample`.

### 2. Define Model Class:
- Created a class `Student` with the following attributes:
  - `string Name`
  - `int Id`
  - `string Grade`
- Included getter and setter methods for encapsulation.

### 3. Define View Class:
- Created a class `StudentView` with a method:
  - `void DisplayStudentDetails(Student student)`  
  - This method displays the student’s name, ID, and grade to the console.

### 4. Define Controller Class:
- Created a class `StudentController` that:
  - Holds references to a `Student` and a `StudentView`.
  - Provides methods to update student details.
  - Provides a method to refresh the view by calling `DisplayStudentDetails()`.

### 5. Test the MVC Implementation:
- In the `Main` method:
  - Created a `Student` object and set initial values.
  - Instantiated `StudentView` and `StudentController`.
  - Modified student data through the controller.
  - Displayed updated information using the view.

## Output:
The **MVC Pattern** was successfully implemented in **C#**, demonstrating a clear separation of concerns:
- **Model** handles data and logic,
- **View** handles presentation,
- **Controller** manages input and updates both model and view.

This pattern simplifies maintenance and scalability of the application.
![image](https://github.com/user-attachments/assets/6b095dc8-df29-4ebd-800e-651856ece2a1)

