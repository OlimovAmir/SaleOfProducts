using MediatR;
using AutoMapper;
using SaleOfProducts.Services.IService;
using SaleOfProducts.CQRS.Commands;

namespace SaleOfProducts.CQRS.Handlers
{
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, string>
    {
        private ISupplierService _service;
        private readonly IMapper _mapper;

        public DeleteSupplierCommandHandler(ISupplierService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var result = _service.Delete(request.Id);
            return Task.FromResult(result);
        }
    }
}
