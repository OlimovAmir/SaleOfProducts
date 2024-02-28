using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseItemController : Controller
    {
        readonly IExpenseItemService _service;

        public ExpenseItemController(IExpenseItemService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IQueryable<ExpenseItem> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public ExpenseItem Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] ExpenseItem item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] ExpenseItem item)
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
