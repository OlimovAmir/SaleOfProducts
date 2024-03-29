﻿namespace SaleOfProducts.Models
{
    public class SaleProducts
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime SaleDate { get; set; } = DateTime.Now;

        // Property for linking to the Product model
        public Product Product { get; set; }

        // A foreign key for communication with the Product model
        public Guid ProductId { get; set; }

        // Property for linking to the Customer model
        public Customer Customer { get; set; }

        // A foreign key for communication with the Customer model
        public Guid CustomerId { get; set; }

        // Additional properties for sale information, such as quantity, etc.
        

        // Constructor
        public SaleProducts(DateTime saleTime ,Product product, Customer customer)
        {
            SaleDate = saleTime;

            Product = product;
            ProductId = product.Id; // Assuming you want to set the foreign key based on the Product's Id

            Customer = customer;
            CustomerId = customer.Id; // Assuming you want to set the foreign key based on the Customer's Id

            
        }

        public SaleProducts()
        {

        }

        public override string ToString()
        {
            return $"{Id} {SaleDate.ToShortDateString()} {ProductId} {CustomerId}";
        }
    }
}
