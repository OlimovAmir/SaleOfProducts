using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueCharacteristicProductController : Controller
    {
        readonly IValueCharacteristicProductService _service;

        public ValueCharacteristicProductController(ValueCharacteristicProductService service)
        {
            _service = service;
        }
        [HttpGet("AllItems")]
        public IQueryable<ValueCharacteristicProduct> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public ValueCharacteristicProduct Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] ValueCharacteristicProduct item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] ValueCharacteristicProduct item)
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
