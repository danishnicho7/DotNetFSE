### Exercise 5: Web API Security with JWT and CORS

---

#### Scenario

This lab demonstrates enabling **CORS**, securing a Web API using **JWT (JSON Web Token)**, and controlling access to APIs with **role-based authorization**.

---

#### Steps Taken

1.  Created a new Web API project `Lab5_JWTAuthCors` inside  
   `week_4/WebApi/`

2.  Enabled **CORS** support for local frontend access.

3.  Installed required NuGet packages:
   - `Microsoft.AspNetCore.Authentication.JwtBearer`
   - `Microsoft.IdentityModel.Tokens`
   - `System.IdentityModel.Tokens.Jwt`

4. Updated `Program.cs` (or `Startup.cs`) to configure JWT:
   - Defined security key
   - Used `AddAuthentication().AddJwtBearer()` with token validation parameters
   - Enabled `app.UseAuthentication()`

5.  Created `AuthController`:
   - Decorated with `[AllowAnonymous]`
   - Added `GenerateJSONWebToken` method that:
     - Sets role as claim (`Admin`)
     - Returns a token valid for 10 minutes

6.  Created `EmployeesController`:
   - Protected with `[Authorize(Roles = "Admin, POC")]`
   - Removed any previous `CustomAuthFilter`
   - Requires valid JWT in the `Authorization: Bearer <token>` header

7.  Tested with **Postman**:
   - Called `AuthController` GET to receive JWT
   - Used JWT to call `EmployeesController` GET
   - Tested expired token (2 min)
   - Verified:
     - Missing/invalid token ⇒ 401 Unauthorized
     - Role mismatch ⇒ 401 Unauthorized
     - Valid token with correct role ⇒ 200 OK

---

#### Output

-  Token generated and received in response
-  Used token successfully in GET request
-  Token expired after 2 minutes → 401 Unauthorized
-  Token with incorrect role → 401 Unauthorized
-  Token with correct role → 200 OK

![output1](https://github.com/user-attachments/assets/bca2eb95-e020-41fd-8530-9e42ba40457c)
![output2](https://github.com/user-attachments/assets/f4355498-4390-4636-8bbf-cd7aef925431)
![output3](https://github.com/user-attachments/assets/a2b99348-0a46-4e95-82ca-5c97e0f182d1)
![output4](https://github.com/user-attachments/assets/e81388c4-08da-4f58-9dad-6a09b2b5bde8)
![output5](https://github.com/user-attachments/assets/0013353e-c188-45b5-8493-714dec52a7cf)
![output6](https://github.com/user-attachments/assets/fc520149-a95c-4452-a88a-c97fc973065b)
