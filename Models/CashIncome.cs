using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashIncome : CashTransaction
    {
        public Guid ExpenseItemId { get; set; } // Идентификатор должности
        public ICollection<IncomeItem> IncomeItems { get; set; } // Ссылка на список групп расходов

        // Конструктор
        public CashIncome(double amount, string description) : base(amount, description)
        {
            IncomeItems = new List<IncomeItem>();
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
