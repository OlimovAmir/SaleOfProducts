using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

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

        private static List<Employee> workers = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amir", LastName = "Olimov" },
            new Employee { Id = 2, Name = "Parvina", LastName = "Olimova" },
            new Employee { Id = 3, Name = "Muborak", LastName = "Olimova" }
        };

        [HttpGet]
        [SwaggerOperation(Summary = "Get a list of employees", Description = "Returns a list of all employees.")]
        public IEnumerable<Employee> Get()
        {
            return workers;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get an employee by ID", Description = "Returns an employee by their ID.")]
        [SwaggerResponse(200, "Success", typeof(Employee))]
        [SwaggerResponse(404, "Not Found")]
        public ActionResult<Employee> GetById(int id)
        {
            var employee = workers.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Create a new employee", Description = "Adds a new employee to the system.")]
        [SwaggerResponse(201, "Created", typeof(Employee))]
        public ActionResult<Employee> Create(Employee employee)
        {
            employee.Id = workers.Count + 1;
            workers.Add(employee);
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Update an employee", Description = "Updates an existing employee.")]
        [SwaggerResponse(204, "No Content")]
        [SwaggerResponse(404, "Not Found")]
        public IActionResult Update(int id, Employee updatedEmployee)
        {
            var existingEmployee = workers.Find(e => e.Id == id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            existingEmployee.Name = updatedEmployee.Name;
            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete an employee", Description = "Removes an employee from the system.")]
        [SwaggerResponse(204, "No Content")]
        [SwaggerResponse(404, "Not Found")]
        public IActionResult Delete(int id)
        {
            var employee = workers.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            workers.Remove(employee);
            return NoContent();
        }

    }
}
