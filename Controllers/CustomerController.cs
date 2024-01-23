using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private static List<Customer> customer = new List<Customer>
        {
            new Customer {
                Id = 1,
                Name = "A client from Russia",
                Status = "LLC",
                Address = "Russia",
                INN = 533328140,
                Phone = 928790000
            },

            new Customer {
                Id = 2,
                Name = "A client from Uzbekistan",
                Status = "LLC",
                Address = "Uzbekistan",
                INN = 519928145,
                Phone = 927722241
            },

        };

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(customer);
        }

    }
}
