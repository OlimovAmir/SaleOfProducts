namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class CashTransaction : BaseEntity
    {
        
        public DateTime? TransactionDate { get; set; } = DateTime.Now;
        public double? Amount { get; set; }
        public string? Description { get; set; }

        // Конструктор по умолчанию
        public CashTransaction() { }

        // Конструктор
        public CashTransaction(double amount, string description)
        {
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} - {TransactionDate}: {Description}, Amount: {Amount}";
        }
    }
}
