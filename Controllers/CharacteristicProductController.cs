using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacteristicProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
