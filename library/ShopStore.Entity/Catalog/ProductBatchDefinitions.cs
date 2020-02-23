using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class ProductBatchDefinitions : EntityBase
    {
        public virtual Products Products { get; set; }
         public virtual Units Units { get; set; }
          public virtual Colors Colors { get; set; }
          public virtual ProductBatchDefinitions MainProductBatchDefinitions { get; set; }
         public virtual Sizes Sizes { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
        public virtual ICollection<ProductBatchItems> ProductBatchItemsList { get; set; }
    }
}
