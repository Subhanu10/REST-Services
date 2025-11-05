using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registerController : ControllerBase
    {
        private readonly IUserService_userService;
            public UsersController(IUserService userService)
        {
            _userService = userService;
        }
    [HttpPosr("register")]
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
