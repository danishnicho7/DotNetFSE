 using Lab4_CRUDEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_CRUDEmployee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Salary = 55000 }
        };

        [HttpPut]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmp = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existingEmp == null)
                return BadRequest("Invalid employee id");

            existingEmp.Name = emp.Name;
            existingEmp.Salary = emp.Salary;

            return Ok(existingEmp);
        }
    }
}
