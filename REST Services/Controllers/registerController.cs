using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_Services;
using JsonThreadOperation.Model;

namespace REST_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registerController : ControllerBase
    {
        private readonly IUserService _userService;
            public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
    [HttpPost("register")]
    public IActionResult Register(User user)
        {
            var result = _userService.RegisterUser(user);
            if (result.Success)
            {
                return Ok(new { message = "User register successfully" });
            }
            else
            {
                return BadRequest(new { message = result.Message });
            }
        }
    }
}
