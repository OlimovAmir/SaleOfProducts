using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueCharacteristicProductController : BaseController<ValueCharacteristicProduct>
    {

        public ValueCharacteristicProductController(ILogger<ValueCharacteristicProductController> logger, IValueCharacteristicProductService service) : base(logger, service)
        {

        }

        

        //[HttpPost("Create")]
        //public IActionResult Create([FromBody] ValueCharacteristicProduct item)
        //{
        //    if (item == null)
        //    {
        //        Console.WriteLine("Item is null in controller");
        //        return BadRequest("Item is null");
        //    }

        //    var result = _service.Create(item);
        //    return Ok(result);
        //}
    }
}
