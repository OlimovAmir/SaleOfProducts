using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class ValueCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        // Foreign key
        public Guid NameCharacteristicProductId { get; set; }
        // Navigation property
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public ValueCharacteristicProduct(string name, Guid nameCharacteristicProductId)
        {
            Name = name;
            NameCharacteristicProductId = nameCharacteristicProductId;
            
        }

        public ValueCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name} {NameCharacteristicProductId}";
        }
    }
}
