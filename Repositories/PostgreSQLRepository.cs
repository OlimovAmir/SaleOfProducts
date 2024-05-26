using Microsoft.AspNetCore.Authentication;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Repositories
{
    public class PostgreSQLRepository<T> : IPostgreSQLRepository<T> where T : BaseEntity
    {
        readonly MemoryContext _context;
        public PostgreSQLRepository(MemoryContext bankContext)
        {
            _context = bankContext;
        }
        public bool Create(T item)
        {
            try
            {
                _context.Add(item);
                var result = _context.SaveChanges();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var item = _context.Set<T>().SingleOrDefault(w => w.Id == id);
                if (item is not null)
                {
                    _context.Remove(item);
                    var result = _context.SaveChanges();
                    return result > 0;
                }
            }
            catch
            { }

            return false;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
            
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().SingleOrDefault(w => w.Id == id);
        }

        public bool Update(T item)
        {
            
            try
            {
                _context.Update(item);
                var result = _context.SaveChanges();
                Console.WriteLine("Repository: Item updated successfully.");
                return result > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Repository: Error updating item. {ex.Message}");
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
                return false;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }


}
