using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
  public   class ProductBatchItems
    {
        public int Quantity { get; set; }
        public int Remainder { get; set; }
        public decimal Cost { get; set; }
         public virtual ProductBatchDefinitions ProductBatchDefinitions { get; set; }
          public virtual Products Products { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
        public virtual ProductBatches ProductBatches { get; set; }
    }
}
