using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }


        public Warehouse(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Warehouse()
        {
            
        }

        public override string ToString()
        {
            return $"\tName:{Name}\tAddress: {Address}";
        }
    }

    
}
