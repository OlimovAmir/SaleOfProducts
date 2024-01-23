using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;

namespace SaleOfProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SupplierController : Controller
    {
        private static List<Supplier> supplier = new List<Supplier>
        {
            new Supplier { Id = 1,}
        };
        
    }
}
