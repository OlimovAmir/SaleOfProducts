using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        public NameCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
