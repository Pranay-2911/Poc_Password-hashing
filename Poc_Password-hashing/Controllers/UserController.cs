using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc_Password_hashing.Dtos;
using Poc_Password_hashing.Models;
using Poc_Password_hashing.Services;

namespace Poc_Password_hashing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Add(UserDto userDto) //add a user 
        {
             var id = _userService.Add(userDto);
            return Ok(id);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginDto) //Login endpoint
        {
            if(_userService.Login(loginDto))
            {
                return Ok("Login in successfull");
            }
            return BadRequest("Invalid Password");
            
        }
    }
}
