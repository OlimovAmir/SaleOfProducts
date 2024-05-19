using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class Company : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string? Status { get; set; } = "Active";

        [Required]
        public string Address { get; set; }

        public int? Phone { get; set; }

        public int? INN { get; set; }

        // Конструктор с необязательными параметрами для nullable полей
        public Company(Guid id, string name, string address, string? status = null, int? phone = null, int? inn = null)
        {
            Id = id;
            Name = name;
            Address = address;
            Status = status ?? "Active"; // Если status null, устанавливаем "Active"
            Phone = phone;
            INN = inn;
        }

        public Company()
        {
            Status = "Active"; // Устанавливаем значение по умолчанию в пустом конструкторе
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Status} {Address} {Phone} {INN}";
        }
       
    }
}
