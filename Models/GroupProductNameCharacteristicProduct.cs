using SaleOfProducts.Models.BaseClassModels;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class GroupProductNameCharacteristicProduct : BaseEntity
    {
        public Guid GroupProductId { get; set; }

        [JsonIgnore]
        public GroupProduct GroupProduct { get; set; }

        public Guid NameCharacteristicProductId { get; set; }
        [JsonIgnore]
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

    }
}
