using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        [Required(ErrorMessage = "Пожалуйста, введите название характеристики продукта")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина названия должна быть от 1 до 100 символов")]
        //[RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Название должно содержать только буквы, цифры и пробелы")]
        public string Name { get; set; }
        public ICollection<GroupProductNameCharacteristicProduct> GroupProductCharacteristics { get; set; }

        public NameCharacteristicProduct(string name, ICollection<GroupProductNameCharacteristicProduct> groupProductCharacteristics)
        {
            
            Name = name;
            GroupProductCharacteristics = groupProductCharacteristics;
        }

        public NameCharacteristicProduct() { }

        public override string ToString()
        {
            return $"{Name} {GroupProductCharacteristics} ";
        }
    }
}
