namespace SaleOfProducts.Models
{
    public class NameValueCharacteristicProduct
    {
        public Guid NameCharacteristicProductId { get; set; }
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public Guid ValueCharacteristicProductId { get; set; }
        public ValueCharacteristicProduct ValueCharacteristicProduct { get; set; }
    }
}
