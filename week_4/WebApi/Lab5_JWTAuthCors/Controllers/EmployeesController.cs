using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_JWTAuthCors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[] {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            return Ok(employees);
        }
    }
}
