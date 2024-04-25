using AutoMapper;
using MediatR;
using SaleOfProducts.CQRS.Queries;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;
using SaleOfProducts.Services;

namespace SaleOfProducts.CQRS.Handlers
{
    public class GetSupplierQueryHandler : IRequestHandler<GetSupplierByIdQuery, Supplier>
    {
        private ISupplierService _service;
        private readonly IMapper _mapper;

        public GetSupplierQueryHandler(ISupplierService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<Supplier> Handle(GetSupplierByIdQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _service.GetById(request.Id);
            return supplier;
        }
    }
}
