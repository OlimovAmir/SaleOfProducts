using Microsoft.AspNetCore.Mvc;
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
    }
}
