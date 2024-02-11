using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using Swashbuckle.AspNetCore.Annotations;
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


        [HttpGet("AllItems")]
        public IEnumerable<Employee> Get()
        {
            return _service.GetAllWithPosition();
        }

        [HttpGet("GetItemById")]
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
