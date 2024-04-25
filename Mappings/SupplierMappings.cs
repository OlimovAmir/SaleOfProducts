using AutoMapper;
using SaleOfProducts.CQRS.Commands; 
using SaleOfProducts.Models;

namespace SaleOfProducts.Mappings
{
    public class SupplierMappings : Profile
    {
        public SupplierMappings() 
        {
            CreateMap<CreateSupplierCommand, Supplier>();
        }
    }
}
