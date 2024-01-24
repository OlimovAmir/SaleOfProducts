using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SupplierController : Controller
    {
        readonly ISupplierService _service;
        public SupplierController(ISupplierService service)
        {
            _service = service;
        }


        private static List<Supplier> supplier = new List<Supplier>
        {
            new Supplier {
                State = SupplierStatus.Orginization,
                Name = "Analitic", 
                Status = "LLC", 
                Address = "Tadjikistan", 
                INN = 510028140, 
                Phone = 928794444 
            },

            new Supplier {
                State = SupplierStatus.Orginization,
                Name = "7Gang",
                Status = "LLC",
                Address = "Tadjikistan",
                INN = 510028145,
                Phone = 927794441
            },

        };

        [HttpGet("AllItems")]
        public IEnumerable<Supplier> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public Supplier Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public string Post([FromBody] Supplier item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Supplier item)
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
