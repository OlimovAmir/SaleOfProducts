using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class UserService : IUserService
    {
        IPostgreSQLRepository<User> _repository;
        public UserService(IPostgreSQLRepository<User> repository)
        {
            _repository = repository;
        }
        public string Create(User item)
        {
            if (string.IsNullOrEmpty(item.Login))
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
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
