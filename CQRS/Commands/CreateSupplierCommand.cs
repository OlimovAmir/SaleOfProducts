using MediatR;
using SaleOfProducts.Models;

namespace SaleOfProducts.CQRS.Commands
{
    public class CreateSupplierCommand : IRequest<Supplier>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
