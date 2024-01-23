using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
