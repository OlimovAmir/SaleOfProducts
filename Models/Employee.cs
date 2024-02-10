using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Employee : Person
    {
        public string Role { get; set; }

        public string Position { get; set; }
    }
}
