using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public class IncomeItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
