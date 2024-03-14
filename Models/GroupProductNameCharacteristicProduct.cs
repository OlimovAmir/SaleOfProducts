using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProductNameCharacteristicProduct : BaseEntity
    {
        public Guid GroupProductId { get; set; }
        public GroupProduct GroupProduct { get; set; }

        public Guid NameCharacteristicProductId { get; set; }
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public GroupProductNameCharacteristicProduct()
        {
            NameCharacteristicProductId = Guid.NewGuid();
            NameCharacteristicProduct = new NameCharacteristicProduct();

        }

    }
}
