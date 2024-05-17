using SaleOfProducts.Models;

namespace SaleOfProducts.Services.IService
{
    public interface ISupplierService : IBaseService<Supplier>
    {
        Task CreateAsync(Supplier supplier);
    }
}
