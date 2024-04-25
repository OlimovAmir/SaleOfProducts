using AutoMapper;
using MediatR;
using SaleOfProducts.CQRS.Commands;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.CQRS.Handlers
{
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, string>
    {
        private ISupplierService _service;
        private readonly IMapper _mapper;

        public UpdateSupplierCommandHandler(ISupplierService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public Task<string> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            var client = _mapper.Map<Supplier>(request);
            var result = _service.Update(request.Id, client);

            return Task.FromResult(result);
        }
    }
}
