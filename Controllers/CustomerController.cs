using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
       

        [HttpGet("AllItems")]
        public IEnumerable<Customer> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public Customer Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] Customer item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Customer item)
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
