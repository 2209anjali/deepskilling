using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Hardcoded list of employees
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Alice", Department = "Finance", Salary = 60000 },
            new Employee { Id = 3, Name = "Bob", Department = "IT", Salary = 70000 }
        };

        // PUT: api/Employee/2
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            // Check for invalid ID
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Check if the employee exists
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update the employee data
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            return Ok(existingEmployee);
        }
    }
}
