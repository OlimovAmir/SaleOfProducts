using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashExpense : CashTransaction
    {
        // Дополнительные свойства для учета расходов, если необходимо
        
        public Guid ExpenseItemId { get; set; } // Идентификатор должности
        public ICollection<ExpenseItem> ExpenseItems { get; set; } // Ссылка на список групп расходов

        public CashExpense(double amount, string description) : base(amount, description)
        {
            ExpenseItems = new List<ExpenseItem>();
        }

        public CashExpense()
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Categories: {string.Join(", ", ExpenseItems.Select(e => e.Name))}";
        }
    }
}
