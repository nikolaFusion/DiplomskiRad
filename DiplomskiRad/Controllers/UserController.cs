using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;
using Utils.Interfaces;

namespace DiplomskiRad.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("user")]
    public class UserController :ControllerBase
    {
        private readonly HttpContext _httpContext;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IHttpContextAccessor contextAccessor)
        {
            _userService = userService;
            _httpContext = contextAccessor.HttpContext;
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

        [HttpGet]
        //[Authorize]
        [Route("logged-in-user")]
        public async Task<ActionResult<IUser>> GetLoggedIn()
        {
            var userID = _httpContext;

            var result = await _userService.GetLoggedInUser("123");

            return Ok(result);
        }

        [HttpGet]
        //[Authorize]
        [Route("get-all")]
        public async Task<ActionResult<IUser>> GetAllUsers()
        {

            var result = await _userService.GetAll();

            return Ok(result);
        }
    }
}
