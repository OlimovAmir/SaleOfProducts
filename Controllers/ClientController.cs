using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly MemoryContext memoryContext;

        public ClientController(MemoryContext memoryContext)
        {
            this.memoryContext = memoryContext;
        }
        [HttpGet("AllItems")]
        public IEnumerable<Client> Get()
        {
            return memoryContext.Clients.AsEnumerable();
        }


        [HttpPost("Create")]
        public void Post([FromBody] Client item)
        {
            try
            {
                memoryContext.Clients.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
           
        }
    }
}
