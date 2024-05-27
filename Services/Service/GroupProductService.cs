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

        public IQueryable<GroupProduct> GetAllWithCharacteristics()
        {
            //var result = _repository.GetAll()
            //    .Include(p => p.NameCharacteristicProducts)
            //    .Select(p => new
            //    {
            //        Id = p.Id, // Устанавливаем идентификатор из базы данных
            //        Name = p.Name,
            //        NameCharacteristicProducts = p.NameCharacteristicProducts.Select(ncp => new
            //        {
            //            Name = ncp.Name,
            //        }).ToList()
            //    });

            //return result;
            return _repository.GetAll()
        .Include(p => p.NameCharacteristicProducts)
        .ThenInclude(ncp => ncp.ValueCharacteristicProducts);

        }

        public GroupProduct GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, GroupProduct item)
        {
            Console.WriteLine("Starting update process...");

            var existingItem = _repository.GetById(id);

            if (existingItem == null)
            {
                Console.WriteLine("Item not found.");
                return "Item not found";
            }

            Console.WriteLine("Existing item found.");

            existingItem.Name = item.Name;

            // Инициализируем коллекцию, если она не инициализирована
            if (existingItem.NameCharacteristicProducts == null)
            {
                existingItem.NameCharacteristicProducts = new List<NameCharacteristicProduct>();
                Console.WriteLine("Initialized NameCharacteristicProducts collection.");
            }

            // Очищаем и перезаписываем коллекцию NameCharacteristicProducts
            existingItem.NameCharacteristicProducts.Clear();
            Console.WriteLine("Cleared existing NameCharacteristicProducts.");

            if (item.NameCharacteristicProducts != null && item.NameCharacteristicProducts.Any())
            {
                foreach (var characteristic in item.NameCharacteristicProducts)
                {
                    Console.WriteLine($"Processing characteristic with Name: {characteristic.Name}");

                    // Проверяем только обязательные поля
                    if (string.IsNullOrEmpty(characteristic.Name))
                    {
                        Console.WriteLine("Characteristic name is required.");
                        return "Failed to update item: NameCharacteristicProduct name is required.";
                    }

                    // Добавляем только обязательные проверки для ValueCharacteristicProducts
                    if (characteristic.ValueCharacteristicProducts != null)
                    {
                        foreach (var valueCharacteristic in characteristic.ValueCharacteristicProducts)
                        {
                            Console.WriteLine($"Processing value characteristic with Name: {valueCharacteristic.Name}");

                            if (string.IsNullOrEmpty(valueCharacteristic.Name))
                            {
                                Console.WriteLine("Value characteristic name is required.");
                                return "Failed to update item: ValueCharacteristicProduct name is required.";
                            }
                        }
                    }

                    existingItem.NameCharacteristicProducts.Add(characteristic);
                    Console.WriteLine("Added characteristic to NameCharacteristicProducts.");
                }
            }

            // Выполняем обновление сущности
            try
            {
                if (_repository.Update(existingItem))
                {
                    Console.WriteLine("Item updated successfully.");
                    return "Item updated";
                }
                else
                {
                    Console.WriteLine("Failed to update item in the repository.");
                    return "Failed to update item";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating item: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    Console.WriteLine($"Inner Stack Trace: {ex.InnerException.StackTrace}");
                    if (ex.InnerException.InnerException != null)
                    {
                        Console.WriteLine($"Inner Inner Exception: {ex.InnerException.InnerException.Message}");
                        Console.WriteLine($"Inner Inner Stack Trace: {ex.InnerException.InnerException.StackTrace}");
                    }
                }
                return "Failed to update item due to an exception.";
            }
        }


    }
}
