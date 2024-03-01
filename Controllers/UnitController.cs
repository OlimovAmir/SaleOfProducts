using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : BaseController<Unit>
    {
        public UnitController(ILogger<UnitController> logger, IUnitService service) : base(logger, service)
        {
        }
    }
}
