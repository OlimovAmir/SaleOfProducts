using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Controllers
{
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : BaseEntity
    {
        
    }
}
