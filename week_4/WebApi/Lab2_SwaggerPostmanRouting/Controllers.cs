using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab2_SwaggerPostmanRouting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string> { "Alice", "Bob", "Charlie" };

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public IActionResult AddEmployee([FromBody] string name)
        {
            employees.Add(name);
            return CreatedAtAction(nameof(GetEmployees), new { }, name);
        }
    }
}
