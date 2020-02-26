using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class ProductBatchItems : EntityBase
    {
        public int Quantity { get; set; }
        public int Remainder { get; set; }
        public decimal Cost { get; set; }
        public virtual ProductBatchDefinitions ProductBatchDefinitions { get; set; }
        public virtual Product Products { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
        public virtual ProductBatches ProductBatches { get; set; }
    }
}