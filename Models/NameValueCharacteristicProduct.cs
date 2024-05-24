namespace SaleOfProducts.Models
{
    public class NameValueCharacteristicProduct
    {
        public Guid NameCharacteristicProductId { get; set; } = Guid.NewGuid();
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public Guid ValueCharacteristicProductId { get; set; }
        public ValueCharacteristicProduct ValueCharacteristicProduct { get; set; }
    }
}
