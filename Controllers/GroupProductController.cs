using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupProductController : Controller
    {
        readonly IGroupProductService _service;

        public GroupProductController(IGroupProductService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<GroupProduct> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("AllItemsWithProduct")]
        public IEnumerable<GroupProduct> GetAllWithProduct()
        {
            return _service.GetAllWithProduct();
        }

        [HttpGet("GetItemById")]
        public GroupProduct Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] GroupProduct item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] GroupProduct item)
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
