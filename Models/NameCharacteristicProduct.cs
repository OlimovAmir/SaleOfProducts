using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public string Name { get; set; }
        // Ссылка на группу продуктов
        public int GroupProductId { get; set; }
        public List<GroupProduct> GroupProducts { get; set; }

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
