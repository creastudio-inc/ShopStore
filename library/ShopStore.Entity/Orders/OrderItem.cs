using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class OrderItem : EntityBase
    {
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxPercent { get; set; }
    }
}