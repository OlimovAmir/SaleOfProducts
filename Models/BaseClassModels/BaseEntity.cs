using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class BaseEntity
    {
        [JsonIgnore]
        
        public virtual Guid Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Id:{Id} ({GetType().Name})";
        }
    }
}
