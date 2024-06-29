using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashIncome : CashTransaction
    {

        public string? FromWhom { get; set; }
        public Guid IncomeItemId { get; set; }
        public IncomeItem IncomeItem { get; set; }

        public ICollection<IncomeItem>? IncomeItems { get; set; } // Ссылка на список групп прихода

        // Конструктор
        public CashIncome(double amount, string description) : base(amount, description)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Description = description;
            IncomeItems = new List<IncomeItem>();
        }



        // Конструктор по умолчанию
        public CashIncome()
        {
            Id = Guid.NewGuid();
            IncomeItems = new List<IncomeItem>();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Categories: {string.Join(", ", IncomeItems.Select(e => e.Name))}";
        }
    }
}
