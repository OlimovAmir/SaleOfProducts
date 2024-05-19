using MediatR;
using SaleOfProducts.Models;

namespace SaleOfProducts.CQRS.Commands
{
    public class CreateSupplierCommand : IRequest<Supplier>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public SupplierStatus? State { get; set; }  // Сделал поле nullable
        public string? Status { get; set; } = "Active";
        public int? INN { get; set; } // Сделал поле nullable
        public int? Phone { get; set; } // Сделал поле nullable
    }
}
