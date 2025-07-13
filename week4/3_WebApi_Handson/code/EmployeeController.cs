using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using YourNamespace.Filters;
namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee>? _employees;
        public EmployeeController()
        {
            if (_employees == null)
                _employees = GetStandardEmployeeList();
        }
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Anjali",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1998, 5, 21)
                }
            };
        }
        [HttpGet("standard")]
        [ProducesResponseType(typeof(Employee), 200)]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(_employees.First());
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [ProducesResponseType(500)] // 👈 Document internal error for Swagger
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("This is a forced test exception");
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            emp.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(emp);
            return Ok(emp);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee emp)
        {
            var existing = _employees.FirstOrDefault(e => e.Id == id);
            if (existing == null) return NotFound();
            existing.Name = emp.Name;
            existing.Salary = emp.Salary;
            existing.Permanent = emp.Permanent;
            existing.Department = emp.Department;
            existing.Skills = emp.Skills;
            existing.DateOfBirth = emp.DateOfBirth;
            return Ok(existing);
        }
    }
}
