using ShopStore.Infrastructure.Models;
using System.Collections.Generic;

namespace ShopStore.Entity
{
    public class ProductBatchDefinitions : EntityBase
    {
        public virtual Product Products { get; set; }
        public virtual Units Units { get; set; }
        public virtual Colors Colors { get; set; }
         public virtual Sizes Sizes { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
        public virtual ICollection<ProductBatchItems> ProductBatchItemsList { get; set; }
    }
}