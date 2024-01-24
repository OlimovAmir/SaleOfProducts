using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class Contract
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        public string ContractId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string ContractType { get; set; }

    }
}
