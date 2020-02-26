using ShopStore.Infrastructure.Models;
using System;

namespace ShopStore.Entity
{
    public class PriceDiscounts : EntityBase
    {
        public decimal Discount { get; set; }
        public decimal? Qualification { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
    }
}