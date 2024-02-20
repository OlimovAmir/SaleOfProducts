using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeItemController : Controller
    {
        readonly IIncomeItemService _service;

        public IncomeItemController(IIncomeItemService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<IncomeItem> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public IncomeItem Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] IncomeItem item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] IncomeItem item)
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
