using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public class GroupProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
