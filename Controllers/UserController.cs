using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        private static List<User> user = new List<User>
        {
            new User { Login = "olimov.amir", Password = "test" },
            new User { Login = "olimova.parvina", Password = "test2" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(user);
        }
    }
}
