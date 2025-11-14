using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_Services.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {


        // POST api/<RegisterController>
        [HttpPost]
        public IActionResult Register([FromBody] LoginItems value)
        {
            if (value == null)
                return BadRequest("Invalid data");

            return Ok(new { message = "Registration successful", data = value });
        }

    }
}
