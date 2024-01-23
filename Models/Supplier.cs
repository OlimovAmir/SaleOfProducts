using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int INN { get; set; }


        public Supplier(string name, string status, string address, string phone, int inn)
        {
            
        }

        public Supplier()
        {
            
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Status} {Address} {Phone} {INN}";
        }
    }
}
