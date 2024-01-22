using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models
{
    public abstract class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person(int id, string name, string lastName, DateTime birthday)
        {
            Id  = id;
            Name = name;
            LastName = lastName;
            Birthday = birthday;
        }

        public Person()
        {
            
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {LastName}, {Birthday.ToShortDateString()}";
        }
    }
}
