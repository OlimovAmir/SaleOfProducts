using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Services
{
    public class GroupProductService : IGroupProductService
    {
        IPostgreSQLRepository<GroupProduct> _repository;

        public GroupProductService(IPostgreSQLRepository<GroupProduct> repository)
        {
            _repository = repository;
        }
        public string Create(GroupProduct item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return item.Id.ToString("D");
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

        public IQueryable<GroupProduct> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<object> GetAllWithCharacteristics()
        {
            var result = _repository.GetAll()
                .Include(p => p.NameCharacteristicProducts)
                .Select(p => new
                {
                    Id = p.Id, // Устанавливаем идентификатор из базы данных
                    Name = p.Name,
                    NameCharacteristicProducts = p.NameCharacteristicProducts.Select(ncp => new
                    {
                        Name = ncp.Name,
                    }).ToList()
                });

            return result;

        }

        public GroupProduct GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, GroupProduct item)
        {
            var existingItem = _repository.GetById(id);

            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Name = item.Name;

            // Очищаем и перезаписываем коллекцию NameCharacteristicProducts
            existingItem.NameCharacteristicProducts?.Clear();
            if (item.NameCharacteristicProducts != null && item.NameCharacteristicProducts.Any())
            {
                foreach (var characteristic in item.NameCharacteristicProducts)
                {
                    existingItem.NameCharacteristicProducts.Add(characteristic);
                }
            }

            // Выполняем обновление сущности
            if (_repository.Update(existingItem))
            {
                return "Item updated";
            }
            else
            {
                return "Failed to update item";
            }
        }

    }
}
