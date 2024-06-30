using SaleOfProducts.Models.BaseClassModels;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class IncomeItem : BaseEntity
    {
        public override Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public ICollection<CashIncome> CashIncomes { get; set; } = new List<CashIncome>();

        // Constructor
        public IncomeItem(string name)
        {
            
            Name = name;
        }



        public IncomeItem() {  }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
