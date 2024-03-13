using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProduct : BaseEntity
    {
        public string Name { get; set; }
        // Коллекция характеристик продуктов, относящихся к данной группе
        public ICollection<NameCharacteristicProduct> Characteristics { get; set; }

        public GroupProduct(string name)
        {
            Name = name;
            Characteristics = new List<NameCharacteristicProduct>(); // Инициализация коллекции
        }

        public GroupProduct()
        {
            Characteristics = new List<NameCharacteristicProduct>(); // Инициализация коллекции
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
