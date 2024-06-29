namespace SaleOfProducts.DTO
{
    public class CashIncomeCreateDto
    {
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string FromWhom { get; set; }
        public string IncomeItemName { get; set; }
    }
}
