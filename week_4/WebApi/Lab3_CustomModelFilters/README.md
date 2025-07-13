
# Lab 3 - Custom Models, Authorization Filters, and Exception Handling in ASP.NET Core Web API

## Scenario
In this lab, we focus on using custom model classes, implementing authorization checks through custom filters, and handling exceptions globally in an ASP.NET Core Web API project.

## Objectives
- Create an action method to return a list of a custom entity
- Demonstrate usage of the [FromBody] attribute
- Implement a custom action filter to check for Authorization token
- Handle exceptions globally using a custom exception filter

---

## Steps Taken

### 1. Web API Using Custom Model Class

- **Created a custom model class `Employee`**
  - Includes properties such as Id, Name, Salary, Permanent, Department, Skills, and DateOfBirth.

- **Created another model class `Department` and `Skill`**
  - Used inside the Employee model to represent nested data.

- **Created a controller named `EmployeeController`**
  - Added actions for GET and POST.
  - Used a private method `GetStandardEmployeeList()` to return a hard-coded list of Employee objects.
  - Used `ProducesResponseType` attribute for 200 OK to indicate a successful GET.

- **Tested using Swagger**
  - Confirmed the correct schema of the Employee model is visible.
  - Used "Try it out" to verify the return of a list of employees.

---

### 2. Usage of [FromBody] Attribute

- **Modified POST method in EmployeeController**
  - Used `[FromBody]` to accept an Employee object in the request body.
  - Ensures data is passed as JSON and deserialized into the model.

- **Tested using Postman**
  - Sent a POST request with Employee JSON in the body.
  - Confirmed the Employee object is correctly received and processed.

---

### 3. Custom Authorization Filter

- **Created a folder `Filters`**
  - Created a class `CustomAuthFilter` that inherits from `ActionFilterAttribute`.

- **Overrode OnActionExecuting method**
  - Checked for `Authorization` key in request headers.
  - Verified it contains the word `Bearer`.

- **Handled failure cases**
  - Returned BadRequest with message "Invalid request - No Auth token" if missing.
  - Returned "Invalid request - Token present but Bearer unavailable" if malformed.

- **Applied `[ServiceFilter(typeof(CustomAuthFilter))]` on `EmployeeController`**
  - This makes sure all requests to EmployeeController are filtered.

- **Tested with Postman**
  - Verified requests with and without valid Authorization headers.

---

### 4. Custom Exception Filter

- **Created class `CustomExceptionFilter`**
  - Implemented `IExceptionFilter` interface.
  - Logged exception message to a file.
  - Set context.Result to return a formatted error response.

- **Registered exception filter globally**
  - So that any unhandled exception in the app is caught.

- **Threw a test exception in GET method**
  - Confirmed it triggers the exception filter and logs the error.

- **Used `ProducesResponseType` attribute**
  - Indicated 500 status code in Swagger documentation for GET method.

---

## Output

- Swagger listed Employee model with correct structure.
- Custom model deserialized properly using `[FromBody]`.
- Authorization header was validated through the filter.
- Unauthorized requests were blocked with meaningful error messages.
- Exceptions were logged and converted into proper HTTP 500 responses.

---
![output](https://github.com/user-attachments/assets/6b179f6c-4e0f-47a5-81a0-99de732cb576)
![output1](https://github.com/user-attachments/assets/ad9ed807-fc6c-44d0-8e50-c8311ae49a5a)


