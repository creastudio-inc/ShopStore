using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class StockHistory : EntityBase
    {
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        [ForeignKey("CreatedBy")]
        public Guid CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public long AdjustedQuantity { get; set; }

        // [StringLength(1000)]
        public string Note { get; set; }
    }
}