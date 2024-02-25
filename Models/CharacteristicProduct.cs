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

        public CharacteristicProduct(string name, string description, decimal price, Dictionary<string, string> specifications)
        {
            Name = name;
            Description = description;
            Price = price;
            Specifications = specifications;
        }

        public override string ToString()
        {
            return $"{Name} {Description} {Price} {Specifications}";
        }
    }
}
