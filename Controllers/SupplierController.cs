using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.CQRS.Commands;
using SaleOfProducts.CQRS.Queries;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SupplierController : Controller
    {
        readonly ISupplierService _service;
        private readonly IMediator _mediator;

        public SupplierController(ISupplierService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }

        [HttpGet("AllItems")]
        public async Task<ActionResult<List<Supplier>>> GetAllClients()
        {
            var query = new GetAllSuppliersQuery();
            var suppliers = await _mediator.Send(query);
            return Ok(suppliers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetClientById(Guid id)
        {
            var query = new GetSupplierByIdQuery() { Id = id };
            var supplier = await _mediator.Send(query);
            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Supplier>> CreateClient(CreateSupplierCommand command)
        {
            var supplier = await _mediator.Send(command);
            return Ok(supplier);
        }

        [HttpPut("Update")]
        public async Task<ActionResult<Supplier>> UpdateClient(Guid id, UpdateSupplierCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public string Delete([FromQuery] Guid id)
        {
            return _service.Delete(id);
        }

    }
}
