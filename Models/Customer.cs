using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Customer : Company
    {
        public CustomerStatus State { get; set; }
    }

    public enum CustomerStatus
    {
        Orginization,
        Persion
    }
}
