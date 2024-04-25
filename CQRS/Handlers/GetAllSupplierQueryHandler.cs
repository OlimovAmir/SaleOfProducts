using AutoMapper;
using MediatR;
using SaleOfProducts.CQRS.Queries;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.CQRS.Handlers
{
    public class GetAllSupplierQueryHandler : IRequestHandler<GetAllSuppliersQuery, List<Supplier>>
    {
        private ISupplierService _service;
        private readonly IMapper _mapper;

        public GetAllSupplierQueryHandler(ISupplierService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<Supplier>> Handle(GetAllSuppliersQuery request, CancellationToken cancellationToken)
        {
            var suppliers = _service.GetAll().ToList();
            return await Task.FromResult(suppliers);
        }
    }
}
