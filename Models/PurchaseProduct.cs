namespace SaleOfProducts.Models
{
    public class PurchaseProduct
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

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
        public PurchaseProduct(DateTime purchaseDate, Product product, Supplier supplier)
        {
            PurchaseDate = purchaseDate;

            Product = product;
            ProductId = product.Id; // Assuming you want to set the foreign key based on the Product's Id

            Supplier = supplier;
            SupplierId = supplier.Id; // Assuming you want to set the foreign key based on the Customer's Id

            
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
