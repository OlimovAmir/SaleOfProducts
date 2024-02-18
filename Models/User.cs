using SaleOfProducts.Models.BaseClassModels;
using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }


        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User()
        {
            
        }

        public override string ToString()
        {
            return $"{Login} {Password}";
        }
    }
}
