using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using Microsoft.Extensions.Logging;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameCharacteristicProductController : BaseController<NameCharacteristicProduct>
    {
        readonly INameCharacteristicProductService _service;
       
        public NameCharacteristicProductController(ILogger<NameCharacteristicProductController> logger, INameCharacteristicProductService service) : base(logger, service)
        {
            _service = service;
        }

        [HttpGet("AllItemsGetAllWithCharacteristics")]
        public IEnumerable<object> GetAllWithCharacteristics()
        {
            return _service.GetAllWithCharacteristic();
        }
    }
}