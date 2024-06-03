using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class ExpenseItem : BaseEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }


        // Constructor
        public ExpenseItem(string name)
        {
            Name = name;
        }

        public ExpenseItem() { }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
