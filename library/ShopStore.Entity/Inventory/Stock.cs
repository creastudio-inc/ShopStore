using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class Stock : EntityBase
    {
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int Quantity { get; set; }

        public int ReservedQuantity { get; set; }
    }
}