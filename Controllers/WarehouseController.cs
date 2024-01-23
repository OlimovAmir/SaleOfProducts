using Microsoft.AspNetCore.Mvc;
using SaleOfProducts.Models;
using System.Collections.Generic;

namespace SaleOfProducts.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : Controller
    {
        private static List<Warehouse> warehouse = new List<Warehouse>
        
        {
            new Warehouse { Id = 1, Name = "Main warehouse", Address = "Tadjikistan"},
            new Warehouse { Id = 2, Name = "Spare parts warehouse", Address = "Tadjikistan"},
            new Warehouse { Id = 3, Name = "Lumber warehouse", Address = "Tadjikistan"}
        };

        [HttpGet]
        [Route("GetWarehouseItems")]
        public IEnumerable<Warehouse> GetWarehouseItems()
        {
            return warehouse;
        }
    }
}
