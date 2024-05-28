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
            if (item.GroupProduct == null || string.IsNullOrEmpty(item.GroupProduct.Name))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }

        public IQueryable<PurchaseProduct> GetAll()
        {
            return _repository.GetAll();
        }

        public PurchaseProduct GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, PurchaseProduct item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Price = item.Price;
                _item.PurchaseDate = item.PurchaseDate;
                _item.Quantity = item.Quantity;
                _item.Unit = item.Unit;
                _item.GroupProduct = item.GroupProduct;
                _item.Supplier = item.Supplier;
                _item.ValueCharacteristicProducts = item.ValueCharacteristicProducts;

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
