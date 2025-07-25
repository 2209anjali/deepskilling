﻿using Microsoft.AspNetCore.Mvc;
namespace mynewapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value " + id);
        }
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Created("", value);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
