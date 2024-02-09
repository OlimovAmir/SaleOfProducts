using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        readonly IUnitService _service;

        public UnitController(IUnitService service)
        {
            _service = service;
        }
        // GET: api/<UnitController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UnitController>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<UnitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UnitController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        // DELETE api/<UnitController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
