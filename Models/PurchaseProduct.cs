using MediatR;

namespace SaleOfProducts.Models
{
    public class PurchaseProduct
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; } // цена
        public double Quantity { get; set; } // количество

        // Property for linking to the Unit model
        public Unit Unit { get; set; } // еденица измерения        

        // A foreign key for communication with the Unit model
        public Guid UnitId { get; set; }

        // Property for linking to the Product model
        public Product Product { get; set; }

        // A foreign key for communication with the Product model
        public Guid ProductId { get; set; }

        // Property for linking to the Customer model
        public Supplier Supplier { get; set; }

        // A foreign key for communication with the Customer model
        public Guid SupplierId { get; set; }

        // Additional properties for sale information, such as quantity, etc.
        

        // Constructor
        public PurchaseProduct(DateTime purchaseDate, decimal price, Unit unit, Product product, Supplier supplier)
        {
            PurchaseDate = purchaseDate;

            Product = product;
            ProductId = product.Id; // Assuming you want to set the foreign key based on the Product's Id

            Supplier = supplier;
            SupplierId = supplier.Id; // Assuming you want to set the foreign key based on the Customer's Id

            Unit = unit;
            UnitId = unit.Id; // Assuming you want to set the foreign key based on the Unit's Id


        }

        public PurchaseProduct()
        {

        }

        public override string ToString()
        {
            return $"{Id} {PurchaseDate.ToShortDateString()} {ProductId} {SupplierId}";
        }
    }
}
