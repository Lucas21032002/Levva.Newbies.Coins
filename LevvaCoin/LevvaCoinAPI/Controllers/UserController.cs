using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoinAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        [HttpPost("Create")]
        public IActionResult Create(UserDto user)
        {
            _userService.Create(user);
            return Created("", user);
        }

        [HttpGet("Get")]
        public ActionResult<UserDto> Get(int id)
        {
           return _userService.Get(id);
        }

        [HttpPut("Att")]
        public IActionResult Update(UserDto user)
        {
            _userService.Update(user);
            return Ok(user);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }


    }

}
