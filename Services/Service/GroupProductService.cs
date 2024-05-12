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
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;

                // Убедимся, что связующая таблица инициализирована
                if (_item.NameCharacteristicProducts == null)
                {
                    _item.NameCharacteristicProducts = new List<NameCharacteristicProduct>();
                }

                // Проверяем, был ли передан новый объект в связующую таблицу
                if (item.NameCharacteristicProducts != null && item.NameCharacteristicProducts.Any())
                {
                    // Добавляем каждый новый объект в связующую таблицу
                    foreach (var characteristic in item.NameCharacteristicProducts)
                    {
                        _item.NameCharacteristicProducts.Add(characteristic);
                    }
                }

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item not found";
        }

    }
}
