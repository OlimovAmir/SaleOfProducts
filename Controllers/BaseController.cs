using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public abstract class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
