using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace SaleOfProducts.CQRS.Commands
{
    public class DeleteSuppierCommand : IRequest<string>
    {
        [FromQuery]
        public Guid Id { get; set; }
    }
}
