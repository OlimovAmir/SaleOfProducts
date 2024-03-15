using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using SaleOfProducts.Services;
using Microsoft.Extensions.Logging;

namespace SaleOfProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameCharacteristicProductController : BaseController<NameCharacteristicProduct>
    {
        public NameCharacteristicProductController(ILogger<NameCharacteristicProductController> logger, INameCharacteristicProductService service) : base(logger, service)
        {
        }

        public override IEnumerable<NameCharacteristicProduct> Get()
        {
            // Получаем все характеристики продуктов
            var nameCharacteristicProducts = base.Get();

            // Для каждой характеристики продукта получаем информацию о связанных группах продуктов
            foreach (var ncp in nameCharacteristicProducts)
            {
                // Получаем группы продуктов, связанные с текущей характеристикой продукта
                var groupProductCharacteristics = _service.GetAll;

                // Добавляем информацию о группах продуктов к текущей характеристике продукта
                //ncp.GroupProductCharacteristics = groupProductCharacteristics;
            }

            // Возвращаем список характеристик продуктов с информацией о связанных группах продуктов
            return nameCharacteristicProducts;
        }

    }
}
