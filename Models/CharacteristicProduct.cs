using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfProducts.Models
{
    public class CharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
       

        [Column(TypeName = "jsonb")] // для PostgreSQL, в других СУБД используйте "json"
        public Dictionary<string, string> Specifications { get; set; }

        public CharacteristicProduct()
        {
            
            Specifications = new Dictionary<string, string>();
        }
    }
}
