using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class GroupProductNameCharacteristicProduct : BaseEntity
    {
        public int NameCharacteristicProductId { get; set; }
        public NameCharacteristicProduct NameCharacteristicProduct { get; set; }

        public int GroupProductId { get; set; }
        public GroupProduct GroupProduct { get; set; }



    }
}
