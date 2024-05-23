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
    }
}
