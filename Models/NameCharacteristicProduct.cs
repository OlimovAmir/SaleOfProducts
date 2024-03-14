using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        // Ссылка на группу продуктов
        public int GroupProductId { get; set; }
        public List<NameCharacteristicProduct> NameCharacteristicProducts { get; set; } // изменение
        public List<GroupProductNameCharacteristicProduct> NameCharacteristicProductGroupProducts { get; set; } // Добавленное свойство

        public NameCharacteristicProduct(string name, int groupProductId)
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
