using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace SaleOfProducts.CQRS.Commands
{
    public class DeleteSupplierCommand : IRequest<string>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
