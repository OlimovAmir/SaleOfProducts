using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IPosition
    {
        IEnumerable<Position> GetAll();
        Position GetById(Guid id);
        string Create(Position worker);
        string Update(Guid id, Position item);
        string Delete(Guid id);
    }
}
