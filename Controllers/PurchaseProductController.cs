using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Controllers
{
    public class PurchaseProductController : BaseController<PurchaseProduct>
    {
        readonly IPurchaseProductService _service;

        public PurchaseProductController(ILogger<PurchaseProductController> logger, IPurchaseProductService service) : base(logger, service)
        {
            _service = service;
        }
    }
}
