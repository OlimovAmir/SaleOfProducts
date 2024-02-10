using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public class Position
    {
        public Guid Id { get; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public Position(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public Position()
        {
            
        }


        public override string ToString()
        {
            return $"{Title} {Description}";
        }

    }
}
