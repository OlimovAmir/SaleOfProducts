using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;
using Microsoft.Extensions.Logging;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameCharacteristicProductController : BaseController<NameCharacteristicProduct>
    {
        public NameCharacteristicProductController(ILogger<NameCharacteristicProductController> logger, INameCharacteristicProductService service) : base(logger, service)
        {
        }
    }
}
