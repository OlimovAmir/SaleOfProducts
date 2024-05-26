using SaleOfProducts.Models.BaseClassModels;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class ValueCharacteristicProduct : BaseEntity
    {
        public override Guid Id { get; set; }
        [JsonIgnore]
        public Guid ValueCharacteristicProductId { get; set; }
        public string Name { get; set; }

        // Navigation property
        [JsonIgnore]
        public ICollection<NameValueCharacteristicProduct> NameValueCharacteristicProducts { get; set; }

        [JsonIgnore]
        public ICollection<NameCharacteristicProduct>? NameCharacteristicProducts { get; set; }

        public ValueCharacteristicProduct(string name)
        {
            Name = name;
            //NameValueCharacteristicProducts = new List<NameValueCharacteristicProduct>();
        }

        public ValueCharacteristicProduct()
        {
           // NameValueCharacteristicProducts = new List<NameValueCharacteristicProduct>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
