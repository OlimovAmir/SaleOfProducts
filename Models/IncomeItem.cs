using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class IncomeItem : BaseEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }


        // Constructor
        public IncomeItem(string name)
        {
            Name = name;
        }

        public IncomeItem()
        {

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
