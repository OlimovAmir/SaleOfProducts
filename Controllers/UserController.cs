using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(ILogger<UserController> logger, IUserService service) : base(logger, service)
        {
        }
    }
}
