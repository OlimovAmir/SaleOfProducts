using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProductNameCharacteristicProduct : BaseEntity
    {
        public Guid NameCharacteristicProductId { get; set; }
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public Guid GroupProductId { get; set; }
        public GroupProduct GroupProduct { get; set; }



    }
}
