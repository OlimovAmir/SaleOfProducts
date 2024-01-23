using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public class UserController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
