using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using SaleOfProducts.Services;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }


        private readonly ILogger<EmployeeController> _logger;
        
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        private static List<Employee> workers = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amir", LastName = "Olimov" },
            new Employee { Id = 2, Name = "Parvina", LastName = "Olimova" },
            new Employee { Id = 3, Name = "Muborak", LastName = "Olimova" }
        };

        [HttpGet("AllItems")]
        [SwaggerOperation(Summary = "Get a list of employees", Description = "Returns a list of all employees.")]
        public IEnumerable<Employee> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        [SwaggerOperation(Summary = "Get an employee by ID", Description = "Returns an employee by their ID.")]
        [SwaggerResponse(200, "Success", typeof(Employee))]
        [SwaggerResponse(404, "Not Found")]
        public Employee Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        [SwaggerOperation(Summary = "Create a new employee", Description = "Adds a new employee to the system.")]
        [SwaggerResponse(201, "Created", typeof(Employee))]
        public string Post([FromBody] Employee item)
        {
            return _service.Create(item);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Employee item)
        {
            return _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }

    }
}
