using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
