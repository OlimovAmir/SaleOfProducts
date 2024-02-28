using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueCharacteristicProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
