using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class Company
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public int INN { get; set; }




        public Company(Guid  id ,string name, string status, string address, int phone, int inn)
        {
            Id = id;
            Name = name;
            Status = status;
            Address = address;
            Phone = phone;
            INN = inn;
        }

        public Company()
        {

        }

        public override string ToString()
        {
            return $"{Id} {Name} {Status} {Address} {Phone} {INN}";
        }
    }
}
