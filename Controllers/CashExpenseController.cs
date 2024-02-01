using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CashExpenseController : Controller
    {
        readonly ICashExpenseService _service;
        // POST: CashExpenseController/Create
        public CashExpenseController(ICashExpenseService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<CashExpense> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public CashExpense Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] CashExpense item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] CashExpense item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }
    }
}
