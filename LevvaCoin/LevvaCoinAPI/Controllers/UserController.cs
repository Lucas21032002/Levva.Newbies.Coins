using LevvaCoinAPI.Domain.Models;
using LevvaCoinAPI.Interfaces;
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

        [HttpGet(Name = "list")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.list();
        }


    }

}
