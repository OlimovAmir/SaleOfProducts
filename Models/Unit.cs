using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Unit : BaseEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }


        // Constructor
        public Unit(string name)
        {
            Name = name;
        }

        public Unit()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
