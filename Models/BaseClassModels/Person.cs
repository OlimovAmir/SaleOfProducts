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
        public string SurName { get; set; }

        public string FullName => $"{Name} {SurName}";
        public DateTime Birthday { get; set; }

        public Person(Guid id, string name, string surName, DateTime birthday)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Birthday = birthday;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {SurName}, {Birthday.ToShortDateString()}";
        }
              
    }
}
