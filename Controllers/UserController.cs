using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        readonly ICashExpenseService _service;

        public CashExpenseController(ICashExpenseService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<User> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public User Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] User item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] User item)
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
