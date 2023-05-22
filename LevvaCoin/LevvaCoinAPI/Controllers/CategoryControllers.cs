using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoinAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;
        public CategoryController(ICategoryService service)
        {
            _CategoryService = service;
        }

        [HttpPost("Create")]
        public IActionResult Create(CategoryDto category)
        {
            _CategoryService.Create(category);
            return Created("", category);
        }

        [HttpGet("Get")]
        public ActionResult<CategoryDto> Get(int id)
        {
            return _CategoryService.Get(id);
        }

        [HttpPut("Att")]
        public IActionResult Update(CategoryDto category)
        {
            _CategoryService.Update(category);
            return Ok(category);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            _CategoryService.Delete(id);
            return Ok();
        }


    }

}
