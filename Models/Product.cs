using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Property for linking to the Unit model
        public Unit Unit { get; set; }

        public double Quantity { get; set; }

        // A foreign key for communication with the Unit model
        public Guid UnitId { get; set; }

        // Constructor
        public Product(string name, decimal price, Unit unit, double quantity)
        {
            Name = name;
            Price = price;
            Unit = unit;
            UnitId = unit.Id; // Assuming you want to set the foreign key based on the Unit's Id
            Quantity = quantity;
        }

        public Product()
        {
            
        }


        public override string ToString()
        {
            return $"{Id} {Name} {Price} {UnitId} {Quantity}";
        }
    }
}
