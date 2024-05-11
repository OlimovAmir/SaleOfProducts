using System;
using System.Collections.Generic;
using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfProducts.Models
{
    public class GroupProduct : BaseEntity
    {
        [Key]
        [Column("ProductId")]
        public Guid Id { get; set; } // Добавляем идентификатор группы продуктов

        [Required(ErrorMessage = "Пожалуйста, введите название характеристики продукта")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Длина названия должна быть от 1 до 100 символов")]
        //[RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Название должно содержать только буквы, цифры и пробелы")]
        public string Name { get; set; }
        
        public ICollection<NameCharacteristicProduct> NameCharacteristicProducts { get; set; }



        public GroupProduct(string name, Guid id)
        {
            Name = name;            
            Id = id;
        }

        public GroupProduct() 
        {
            
        }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
