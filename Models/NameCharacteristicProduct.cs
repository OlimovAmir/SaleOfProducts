using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfProducts.Models
{
    public class NameCharacteristicProduct : BaseEntity
    {
        [Key]
        [Column("ProductGroupId")]
        public override Guid Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название характеристики продукта")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина названия должна быть от 1 до 100 символов")]
        //[RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Название должно содержать только буквы, цифры и пробелы")]


        public string Name { get; set; }        

        public NameCharacteristicProduct(string name)
        {            
            Name = name;            
        }

        public NameCharacteristicProduct() { }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
