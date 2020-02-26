using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class ShipmentItem : EntityBase
    {
        public int Quantity { get; set; }

        [ForeignKey("Shipment")]
        public Guid ShipmentId { get; set; }

        public Shipment Shipment { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}