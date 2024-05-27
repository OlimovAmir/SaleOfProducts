using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;
using System;
using System.Linq;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Results;

namespace SaleOfProducts.Controllers
{
    [Route("odata/[controller]")]
    public class GroupProductsODataController : ODataController
    {
        private readonly IGroupProductService _service;

        public GroupProductsODataController(IGroupProductService service)
        {
            _service = service;
        }

        [EnableQuery]
        [HttpGet]
        public IQueryable<GroupProduct> Get()
        {
            return _service.GetAllWithCharacteristics();
        }

        [EnableQuery]
        [HttpGet("{key}")]
        public SingleResult<GroupProduct> Get([FromODataUri] Guid key)
        {
            var result = _service.GetAllWithCharacteristics().Where(g => g.Id == key);
            return SingleResult.Create(result);
        }
    }
}
