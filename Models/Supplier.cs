using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class Supplier : Company
    {
        public SupplierStatus? State { get; set; }

        public ICollection<PurchaseProduct> PurchaseProducts { get; set; }
    }

    public enum SupplierStatus
    {
        Orginization,
        Persion
    }
}
