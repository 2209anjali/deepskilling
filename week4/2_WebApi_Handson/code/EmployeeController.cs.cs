using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mynewapi.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var employees = new List<string> { "Jonny", "Jahan", "Alia" };
            return Ok(employees);
        }
    }
}
