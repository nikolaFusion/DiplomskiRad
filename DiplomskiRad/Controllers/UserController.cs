using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;

namespace DiplomskiRad.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("user")]
    public class UserController :ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<ActionResult<bool>> Login([FromBody] LoginDto user)
        {
            var result = await _userService.Login(new UserDto(user));
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("registration")]
        public async Task<ActionResult<bool>> Registration([FromBody] RegostrationDto user)
        {
            var result = await _userService.Registration(new UserDto(user));
            return Ok(result);
        }
    }
}
