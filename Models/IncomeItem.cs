using SaleOfProducts.Models.BaseClassModels;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class IncomeItem : BaseEntity
    {        
        public string Name { get; set; }

        [JsonIgnore]
        public Guid? CashIncomeId { get; set; } // Внешний ключ на CashIncome
        [JsonIgnore]
        public CashIncome? CashIncome { get; set; } // Навигационное свойство на CashIncome
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
