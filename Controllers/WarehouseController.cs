using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
