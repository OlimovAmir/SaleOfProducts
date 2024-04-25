using MediatR;
using SaleOfProducts.Models;

namespace SaleOfProducts.CQRS.Queries
{
    public class GetSupplierByIdQuery : IRequest<Supplier>
    {
        public Guid Id { get; set; }
    }
}
