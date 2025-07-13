### Exercise 4: Web API CRUD Operation - Update Employee

---

#### Scenario

This lab demonstrates how to create an API with a `PUT` action method to update employee data using the `FromBody` attribute.  
The update uses a **hardcoded list of employees**, performs **validation on input**, and returns appropriate **ActionResult** responses.  
Swagger and Postman are used to test the API.

---

#### Steps Taken

1.  Created a new Web API project `Lab4_CRUDEmployee` inside  
   `week_4/WebApi/`

2.  Added `Employee` model class with `Id`, `Name`, and `Salary` properties.

3.  Created `EmployeesController` with a `PUT` method:
   - Accepts `Employee` data using `[FromBody]`.
   - Validates:
     - If `Id <= 0` → returns `BadRequest("Invalid employee id")`
     - If `Id` not found in list → returns `BadRequest("Invalid employee id")`
     - If `Id` is valid → updates employee and returns updated object.

4.  Configured Swagger in `Program.cs` for testing.

5.  Ran and tested using:
   - **Swagger UI**
   - **Postman** for PUT request

---

#### Output

- Swagger UI successfully launches at `http://localhost:<port>/swagger`
- PUT request updates employee correctly
- Proper error messages shown for invalid IDs
![output1](https://github.com/user-attachments/assets/09a0a911-cbd3-47ff-928e-1d2805c0b04a)
![output2](https://github.com/user-attachments/assets/76f6dec7-d4ee-4fc4-a713-7d76c6ff8014)
![output3](https://github.com/user-attachments/assets/3d99aab5-64f7-4aa2-8b24-58949cd1d6c2)
![output4](https://github.com/user-attachments/assets/9b591b19-245e-4e54-b8b6-7da56afdb514)



