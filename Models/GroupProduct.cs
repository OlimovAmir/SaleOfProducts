using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProduct : BaseEntity
    {
        public Guid GroupProductId { get; set; }
        public string Name { get; set; }

        //public List<NameCharacteristicProduct> NameCharacteristicProducts { get; set; }
        // Коллекция характеристик продуктов, относящихся к данной группе
        public ICollection<GroupProductNameCharacteristicProduct> GroupProductNameCharacteristicProducts { get; set; }

        public GroupProduct(string name, Guid groupProductId)
        {
            GroupProductId = groupProductId;
            Name = name;
            //NameCharacteristicProducts = new List<NameCharacteristicProduct>(); // Инициализация коллекции
        }

        public GroupProduct()
        {
            //NameCharacteristicProducts = new List<NameCharacteristicProduct>(); // Инициализация коллекции
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
