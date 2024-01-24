using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

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
        private static List<Customer> customer = new List<Customer>
        {
            new Customer {
                
                Name = "A client from Russia",
                Status = "LLC",
                Address = "Russia",
                INN = 533328140,
                Phone = 928790000
            },

            new Customer {
                
                Name = "A client from Uzbekistan",
                Status = "LLC",
                Address = "Uzbekistan",
                INN = 519928145,
                Phone = 927722241
            },

        };

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
