using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class ProductBatches
    {
        public DateTime? ManufactureDate { get; set; }
         public string BatchCode { get; set; }
        public int? DaysFromBuyToDeliver { get; set; }
         public decimal? ShipmentTotalCost { get; set; }
        public decimal? ProductTotalPrice { get; set; }
        public string AlternativeCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public virtual ICollection<ProductBatchItems> ProductBatchItems { get; set; }
        public virtual Vendors Vendors { get; set; }
        public virtual Products Products { get; set; }
    }
}
