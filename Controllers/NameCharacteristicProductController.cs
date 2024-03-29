using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;
using Microsoft.Extensions.Logging;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameCharacteristicProductController : Controller
    {
        readonly INameCharacteristicProductService _service;

        public NameCharacteristicProductController(INameCharacteristicProductService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<NameCharacteristicProduct> Get()
        {
            return _service.GetAllWithCharacteristic();
        }

        [HttpGet("GetItemById")]
        public NameCharacteristicProduct Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] NameCharacteristicProduct item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] NameCharacteristicProduct item)
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
