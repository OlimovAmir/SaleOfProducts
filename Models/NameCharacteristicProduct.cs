using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        [JsonIgnore]        
        public Guid NameCharacteristicProductId { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название характеристики продукта")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина названия должна быть от 1 до 100 символов")]
        //[RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Название должно содержать только буквы, цифры и пробелы")]


        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<GroupProduct>? GroupProducts { get; set; }

    }
}
