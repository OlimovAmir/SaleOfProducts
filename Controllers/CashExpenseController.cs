using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CashExpenseController : BaseController<CashExpense>
    {
        public CashExpenseController(ILogger<CashExpenseController> logger, ICashExpenseService service) : base(logger, service)
        {
        }
    }
}
