using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class ValueCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }

        public ValueCharacteristicProduct(string name)
        {
            Name = name;
        }

        public ValueCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
