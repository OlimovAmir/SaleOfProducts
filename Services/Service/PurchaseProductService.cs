using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services.Service
{
    public class PurchaseProductService : IPurchaseProductService
    {
        IPostgreSQLRepository<PurchaseProduct> _repository;

        public PurchaseProductService(IPostgreSQLRepository<PurchaseProduct> repository)
        {
            _repository = repository;
        }

        public string Create(PurchaseProduct item)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PurchaseProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public PurchaseProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, PurchaseProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
