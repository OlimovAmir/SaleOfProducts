using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.CQRS.Commands;
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
        public IEnumerable<Supplier> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetItemById")]
        public Supplier Get(Guid id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Supplier>> CreateClient(CreateSupplierCommand command)
        {
            var supplier = await _mediator.Send(command);
            return Ok(supplier);
        }

        [HttpPut("Update")]
        public string Put([FromQuery] Guid id, [FromBody] Supplier item)
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
