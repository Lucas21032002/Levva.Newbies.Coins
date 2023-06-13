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
        public TransactionController(ITransactionService service)
        {
            _TransactionService = service;
        }

        [HttpPost]
        public IActionResult Create(TransactionDto transaction)
        {
            _TransactionService.Create(transaction);
            return Created("", transaction);
        }

        [HttpGet]
        public ActionResult<TransactionDto> Get(int id)
        {
            return _TransactionService.Get(id);
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