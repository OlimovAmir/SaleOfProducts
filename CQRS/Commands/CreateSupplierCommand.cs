using MediatR;

namespace SaleOfProducts.CQRS.Commands
{
    public class CreateSupplierCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
