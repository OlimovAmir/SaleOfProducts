using AutoMapper;
using MediatR;
using SaleOfProducts.CQRS.Commands;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.CQRS.Handlers
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, Supplier>
    {
        private ISupplierService _service;
        private readonly IMapper _mapper;

        public CreateSupplierCommandHandler(ISupplierService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<Supplier> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Supplier>(request);
            _service.Create(user);
            return Task.FromResult(user);
        }
    }
}
