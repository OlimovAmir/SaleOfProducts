using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashIncome : CashTransaction
    {

        public string? FromWhom { get; set; }
        public Guid? CashIncomeId { get; set; } // Идентификатор должности
        public ICollection<IncomeItem>? IncomeItems { get; set; } // Ссылка на список групп расходов



        // Конструктор
        public CashIncome(double amount, string description) : base(amount, description)
        {
            
        }

        // Конструктор по умолчанию
        public CashIncome()
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Categories: {string.Join(", ", IncomeItems.Select(e => e.Name))}";
        }
    }
}
