namespace SaleOfProducts.DTO
{
    public class CashIncomeCreateDto
    {
        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string FromWhom { get; set; }
        public Guid incomeItemId { get; set; }
    }
}
