using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class Product : BaseEntity
    {
        [Key]
        //[Column("ProductId")]
        [JsonIgnore]
        public override Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } = string.Empty;

        [JsonIgnore]
        public Guid GroupId { get; set; }
        public GroupProduct GroupProduct { get; set; }

        // Constructor
        public Product(string name, string description)
        {
            Name = name;
            Description = description;           
        }

        public Product()
        {
            
        }


        public override string ToString()
        {
            return $"{Id} {Name} {Description}";
        }
    }
}
