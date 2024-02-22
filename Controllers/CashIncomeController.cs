using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CashIncomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
