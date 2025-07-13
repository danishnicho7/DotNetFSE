# Lab 2 - Swagger, Postman, and Routing in ASP.NET Core Web API

## Scenario
This lab demonstrates how to:
- Integrate Swagger in a Web API project using Swashbuckle.AspNetCore
- Use Postman to test Web API endpoints
- Customize routing using attributes and ActionName

## Objectives
- Demonstrate Swagger installation to WebAPI and listing in the browser
- Use Postman tool to test WebAPI methods (GET/POST)
- Demonstrate the usage of Route and Name attributes in HTTP requests
- Create a simple WebAPI with Read and Write actions

## Steps Taken

1. **Created ASP.NET Core Web API Project**
   - A new Web API project was created using the API template.

2. **Installed Swagger Package**
   - Swashbuckle.AspNetCore was installed via NuGet.

3. **Configured Swagger**
   - In `Program.cs`:
     - Added `builder.Services.AddSwaggerGen(...)` with metadata like Title, Version, Contact, License.
     - Added `app.UseSwagger()` and `app.UseSwaggerUI(...)` in the middleware pipeline.

4. **Created EmployeeController**
   - Used `[Route("api/Emp")]` to define a custom route.
   - Used `[ActionName("GetAll")]` and `[ActionName("Create")]` to name actions.
   - Implemented GET and POST methods.

5. **Tested with Swagger**
   - Ran the app and visited `/swagger` in the browser.
   - Verified metadata and used "Try it out" and "Execute" buttons to test endpoints.

6. **Tested with Postman**
   - Used Postman to send a GET request to `https://localhost:[port]/api/Emp`.
   - Used POST with JSON body to create a new employee.
   - Verified response in Body and checked HTTP status.

## Output

- Swagger UI displayed configured metadata.
- Endpoints were listed under EmployeeController.
- GET and POST methods executed correctly through both Swagger and Postman.
- Route attribute mapped the controller to `/api/Emp`.
- ActionName attributes allowed naming of methods for clarity.
- <img width="1280" height="718" alt="image" src="https://github.com/user-attachments/assets/a5620a3c-432f-47ae-b78d-ac8575bf7b96" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/bd7c267b-e942-456b-ac1f-9e2362e8a0be" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/3cba518b-8062-4199-8c17-c49474487e67" />
<img width="1280" height="673" alt="image" src="https://github.com/user-attachments/assets/e9b775ca-ed0d-4305-8353-4bea4f2a936c" />



