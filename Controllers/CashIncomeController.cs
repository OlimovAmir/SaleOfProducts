using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CashIncomeController : Controller
    {
        readonly ICashIncomeService _service;

        public CashIncomeController(ICashIncomeService service)
        {
            _service = service;
        }
    }
}
