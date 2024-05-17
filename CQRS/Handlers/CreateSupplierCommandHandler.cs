using MediatR;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using SaleOfProducts.CQRS.Commands;
using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, Supplier>
{
    private readonly ISupplierService _service;
    private readonly IMapper _mapper;

    public CreateSupplierCommandHandler(ISupplierService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<Supplier> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
    {
        // Преобразование запроса в модель Supplier
        var supplier = _mapper.Map<Supplier>(request);

        // Асинхронное создание поставщика
        await _service.CreateAsync(supplier);

        // Возврат созданного поставщика
        return supplier;
    }
}
