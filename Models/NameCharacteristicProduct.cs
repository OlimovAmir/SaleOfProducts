using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }

        public NameCharacteristicProduct(string name)
        {
            Name = name;
        }

        public NameCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
