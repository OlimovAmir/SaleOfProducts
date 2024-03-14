using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        // Ссылка на группу продуктов
        public Guid GroupProductId { get; set; }
        public List<NameCharacteristicProduct> NameCharacteristicProducts { get; set; } // изменение
        public List<GroupProductNameCharacteristicProduct> NameCharacteristicProductGroupProducts { get; set; } // Добавленное свойство
        public List<ValueCharacteristicProduct> ValueCharacteristicProducts { get; set; }

        public NameCharacteristicProduct(string name, Guid groupProductId)
        {
            Name = name;
            GroupProductId = groupProductId;
        }

        public NameCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name} {GroupProductId}";
        }
    }
}
