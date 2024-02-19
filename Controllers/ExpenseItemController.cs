using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public class ExpenseItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
