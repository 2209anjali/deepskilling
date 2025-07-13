using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value " + id);
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
