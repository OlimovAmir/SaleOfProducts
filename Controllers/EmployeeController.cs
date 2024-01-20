using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var workers = new List<Employee>();
            workers.Add(new Employee() { Name  = "Test1"});
            workers.Add(new Employee() { Name  = "Test2" });
            return workers;
        }
    }
}
