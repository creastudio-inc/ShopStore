using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace ShopStore.Entity
{
    public class ProductPrices : EntityBase
    {
        public decimal Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual ICollection<PriceDiscounts> PriceDiscountsList { get; set; }
    }
}