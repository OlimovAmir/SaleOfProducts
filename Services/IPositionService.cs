using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IPositionService
    {
        IEnumerable<Position> GetAll();
        Position GetById(Guid id);
        string Create(Position item);
        string Update(Guid id, Position item);
        string Delete(Guid id);
    }
}
