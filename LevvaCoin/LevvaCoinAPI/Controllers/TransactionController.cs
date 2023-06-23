using LevvaCoinAPI.Logic.Dto;
using LevvaCoinAPI.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LevvaCoinAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _TransactionService;
        private readonly ICategoryService _CategoryService;
        public TransactionController(ITransactionService service, ICategoryService categoryService)
        {
            _TransactionService = service;
            _CategoryService = categoryService;
        }

        [HttpPost]
        public ActionResult<TransactionDto> Create(CreateTransactionDto transaction)
        {
            var userId = User.Identity.Name;
            var category = _CategoryService.Get(transaction.CategoryId);
            var transactionCreated =_TransactionService.Create(Convert.ToInt32(userId),transaction);
            transactionCreated.Category = category;
            return Created("", transactionCreated);
        }

        [HttpGet]
        public ActionResult<TransactionDto> Get(int id)
        {
            return _TransactionService.Get(id);
        }

        [HttpGet("list")]
        public ActionResult<List<TransactionDto>> GetAll()
        {
            return _TransactionService.GetAll();
        }

        [HttpPut]
        public IActionResult Update(TransactionDto transaction)
        {
            _TransactionService.Update(transaction);
            return Ok(transaction);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _TransactionService.Delete(id);
            return Ok();
        }


    }

}