using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProduct : BaseEntity
    {
        public string Name { get; set; }

        public GroupProduct(string name)
        {
            Name = name;
        }

        public GroupProduct()
        {

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
