namespace SaleOfProducts.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Property for linking to the Unit model
        public Unit Unit { get; set; }

        // A foreign key for communication with the Unit model
        public Guid UnitId { get; set; }


    }
}
