using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashExpense : CashTransaction
    {
        // Дополнительные свойства для учета расходов, если необходимо
        
        public Guid PositionId { get; set; } // Идентификатор должности
        public ExpenseItem ExpenseItem { get; set; } // Ссылка на должность

        // Конструктор
        public CashExpense(double amount, string description, ExpenseItem expenseItem)
            : base(amount, description)
        {
            Amount = amount;
            Description = description;
            ExpenseItem = expenseItem;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Category: {Description} {ExpenseItem}";
        }
    }
}
