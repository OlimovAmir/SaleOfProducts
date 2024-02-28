using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameCharacteristicProductController : Controller
    {
        readonly IUnitService _service;

        public UnitController(IUnitService service)
        {
            _service = service;
        }
        [HttpGet("AllItems")]
        public IEnumerable<Unit> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public Unit Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] Unit item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Unit item)
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
