using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        public override Guid Id { get; set; } = Guid.NewGuid();
        [JsonIgnore]
        public Guid NameCharacteristicProductId { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название характеристики продукта")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина названия должна быть от 1 до 100 символов")]
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<GroupProduct>? GroupProducts { get; set; }
        public ICollection<ValueCharacteristicProduct>? ValueCharacteristicProducts { get; set; }
        

        public NameCharacteristicProduct()
        {
            
        }

    }
}
