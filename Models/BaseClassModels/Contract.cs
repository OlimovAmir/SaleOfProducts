namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class Contract
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContractId { get; set; }
        public DateTime Date { get; set; }
        public string ContractType { get; set; }

    }
}
