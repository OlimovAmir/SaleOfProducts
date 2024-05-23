using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    public class ValueCharacteristicProductController : BaseController<ValueCharacteristicProduct>
    {
        public ValueCharacteristicProductController(ILogger<ValueCharacteristicProductController> logger, IValueCharacteristicProductService service) : base(logger, service)
        {

        }

        [HttpPost]
        public IActionResult Post(ValueCharacteristicProduct item)
        {
            if (item == null)
            {
                return BadRequest("Item is null");
            }

            item.Id = Guid.Parse(item.Name);

            

            return Ok("Item created successfully");
        }
    }
}
