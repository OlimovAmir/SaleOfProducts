using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashExpense : CashTransaction
    {
        // Дополнительные свойства для учета расходов, если необходимо
        public string Category { get; set; }
        public Guid PositionId { get; set; } // Идентификатор должности
        public ExpenseItem ExpenseItem { get; set; } // Ссылка на должность

        // Конструктор
        public CashExpense(double amount, string description, string category)
            : base(amount, description)
        {
            Amount = amount;
            Category = category;
            Description = description;
            Category = category;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Category: {Category}";
        }
    }
}
