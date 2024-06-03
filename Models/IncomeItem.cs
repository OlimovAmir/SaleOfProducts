using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class IncomeItem : BaseEntity
    {        
        public string Name { get; set; }
        public Guid CashIncomeId { get; set; } // Внешний ключ на CashIncome
        public CashIncome CashIncome { get; set; } // Навигационное свойство на CashIncome
        // Constructor
        public IncomeItem(string name)
        {
            Name = name;
        }

        public IncomeItem() { }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
