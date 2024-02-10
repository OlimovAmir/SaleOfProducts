using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class PositionServise : IPositionServise
    {
        private readonly MemoryContext _dbContext;

        public PositionServise(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string Create(Position item)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Position> GetAll()
        {
            throw new NotImplementedException();
        }

        public Position GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, Position item)
        {
            throw new NotImplementedException();
        }
    }
}
