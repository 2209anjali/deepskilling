using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAPI.Controllers
{
    [Authorize(Roles = "Admin,POC")] // ✅ Allow only Admin or POC roles
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // 🔧 Static in-memory employee list
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Jay", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Alia", Department = "Finance", Salary = 60000 },
            new Employee { Id = 3, Name = "Bobby", Department = "IT", Salary = 70000 }
        };

        // 🟢 GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(employees);
        }

        // 🔄 PUT: api/Employee/2
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
                return BadRequest("Invalid employee id");

            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            return Ok(existingEmployee);
        }
    }
}
