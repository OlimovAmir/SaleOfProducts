using MediatR;
using SaleOfProducts.Models;

namespace SaleOfProducts.CQRS.Commands
{
    public class CreateSupplierCommand : IRequest<Supplier>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public SupplierStatus State { get; set; }
        public SupplierStatus Status { get; set; }
        public string INN { get; set; }
        public string Phone { get; set; }
    }
}
