using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfProducts.Models
{
    public class CharacteristicProduct : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }

        [Column(TypeName = "jsonb")] // для PostgreSQL, в других СУБД используйте "json"
        public Dictionary<string, string> Specifications { get; set; }

        public CharacteristicProduct()
        {
            Colors = new List<string>();
            Sizes = new List<string>();
            Specifications = new Dictionary<string, string>();
        }
    }
}
