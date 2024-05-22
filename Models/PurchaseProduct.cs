using MediatR;
using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Models
{
    public class PurchaseProduct : BaseEntity
    {
       
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; } // цена
        public double Quantity { get; set; } // количество

        // Property for linking to the Unit model
        public Unit Unit { get; set; } // еденица измерения        

        // A foreign key for communication with the Unit model
        public Guid UnitId { get; set; }

        // Property for linking to the Product model
        public GroupProduct GroupProduct { get; set; }

        // A foreign key for communication with the Product model
        public Guid GroupProductId { get; set; }

        // Property for linking to the Customer model
        public Supplier Supplier { get; set; }

        // A foreign key for communication with the Customer model
        public Guid SupplierId { get; set; }

        // Additional properties for sale information, such as quantity, etc.


        // Связанные записи ValueCharacteristicProduct для этой покупки
        public ICollection<ValueCharacteristicProduct> ValueCharacteristicProducts { get; set; }


        // Constructor
        public PurchaseProduct(DateTime purchaseDate, decimal price, Unit unit, GroupProduct groupProduct, Supplier supplier)
        {
            PurchaseDate = purchaseDate;

            GroupProduct = groupProduct;
            GroupProductId = groupProduct.Id; // Assuming you want to set the foreign key based on the Product's Id

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
            return $"{Id} {PurchaseDate.ToShortDateString()} {GroupProductId} {SupplierId}";
        }
    }
}
