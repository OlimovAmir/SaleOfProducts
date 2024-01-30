using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class CashIncome : CashTransaction
    {
        // Дополнительные свойства для учета приходов, если необходимо
        public string Source { get; set; }

        // Конструктор
        public CashIncome(double amount, string description, string source)
            : base(amount, description)
        {
            Source = source;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Source: {Source}";
        }
    }
}
