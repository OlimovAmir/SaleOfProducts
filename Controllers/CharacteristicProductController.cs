using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacteristicProductController : Controller
    {
        readonly ICharacteristicProductService _service;

        public CharacteristicProductController(ICharacteristicProductService service)
        {
            _service = service;
        }

        [HttpGet("AllItems")]
        public IEnumerable<CharacteristicProduct> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public CharacteristicProduct Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromForm] CharacteristicProduct item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] CharacteristicProduct item)
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
