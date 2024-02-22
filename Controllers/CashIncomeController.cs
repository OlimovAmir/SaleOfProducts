using Microsoft.AspNetCore.Mvc;

namespace SaleOfProducts.Controllers
{
    public class CashIncomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
