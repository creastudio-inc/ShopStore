using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace ShopStore.Entity
{
    public class ProductBatches : EntityBase
    {
        public DateTime? ManufactureDate { get; set; }
        public string BatchCode { get; set; }
        public int? DaysFromBuyToDeliver { get; set; }
        public decimal? ShipmentTotalCost { get; set; }
        public decimal? ProductTotalPrice { get; set; }
        public string AlternativeCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public virtual ICollection<ProductBatchItems> ProductBatchItems { get; set; }
        public virtual Vendor Vendors { get; set; }
        public virtual Product Products { get; set; }
    }
}