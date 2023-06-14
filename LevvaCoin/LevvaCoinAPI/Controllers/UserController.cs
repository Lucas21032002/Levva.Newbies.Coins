using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create(UserDto user)
        {
            _userService.Create(user);
            return Created("", user);
        }

        [HttpGet]
        public ActionResult<UserDto> Get(int id)
        {
           return _userService.Get(id);
        }
        [HttpGet("list")]
        public ActionResult<List<UserDto>> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpPut]
        public IActionResult Update(UserDto user)
        {
            _userService.Update(user);
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public ActionResult<LoginDto> Login(LoginDto loginDto)
        {
            var login = _userService.Login(loginDto);

            if (login == null)
                return BadRequest("Usuário inválido");

            return Ok(login);
        }

    }

}
