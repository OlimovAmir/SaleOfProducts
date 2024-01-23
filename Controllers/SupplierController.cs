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
            new Supplier { 
                Id = 1, 
                Name = "Analitic", 
                Status = "LLC", 
                Address = "Tadjikistan", 
                INN = 510028140, 
                Phone = 928794444 
            },

            new Supplier {
                Id = 2,
                Name = "7Gang",
                Status = "LLC",
                Address = "Tadjikistan",
                INN = 510028145,
                Phone = 927794441
            },

        };

        [HttpGet]
        public ActionResult<IEnumerable<Supplier>> Get()
        {
            return Ok(supplier);
        }

    }
}
