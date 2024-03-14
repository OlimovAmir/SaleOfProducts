using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        // Ссылка на группу продуктов
        public Guid NameCharacteristicProductId { get; set; }
        
        public List<GroupProductNameCharacteristicProduct> NameCharacteristicProductGroupProducts { get; set; } // Добавленное свойство
        //public List<ValueCharacteristicProduct> ValueCharacteristicProducts { get; set; }

        public NameCharacteristicProduct(string name)
        {
            Name = name;
            
        }

        public NameCharacteristicProduct()
        {
            
        }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
