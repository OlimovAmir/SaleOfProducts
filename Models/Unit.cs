using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<PurchaseProduct> PurchaseProducts { get; set; }

        // Constructor
        public Unit(string name)
        {
            Name = name;
        }

        public Unit() { }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
