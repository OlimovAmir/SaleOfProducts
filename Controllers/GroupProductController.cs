using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
