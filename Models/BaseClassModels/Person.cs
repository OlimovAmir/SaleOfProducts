using System.ComponentModel.DataAnnotations;

namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class Person
    {
        [Key]
        public Guid Id { get; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        public string FullName => $"{Name} {LastName}";
        public DateTime Birthday { get; set; }

        public Person(Guid id, string name, string lastName, DateTime birthday)
        {
            Id = id;
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
