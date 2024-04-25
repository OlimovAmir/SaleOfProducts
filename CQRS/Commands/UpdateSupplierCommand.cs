using MediatR;
using System.Text.Json.Serialization;

namespace SaleOfProducts.CQRS.Commands
{
    public class UpdateSupplierCommand : IRequest<string>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
