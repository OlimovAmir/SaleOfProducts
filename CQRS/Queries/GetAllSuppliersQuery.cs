using MediatR;
using SaleOfProducts.Models;

namespace SaleOfProducts.CQRS.Queries
{
    public class GetAllSuppliersQuery : IRequest<List<Supplier>>
    {
    }
}
