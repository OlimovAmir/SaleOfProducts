using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameCharacteristicProductController : BaseController<NameCharacteristicProduct>
    {
        public NameCharacteristicProductController(ILogger<NameCharacteristicProductController> logger, INameCharacteristicProductService service) : base(logger, service)
        {
        }
    }
}
