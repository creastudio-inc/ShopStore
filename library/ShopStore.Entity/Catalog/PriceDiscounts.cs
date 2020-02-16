using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
     public class PriceDiscounts
    { 
        public decimal Discount { get; set; } 
        public decimal? Qualification { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ProductPrices ProductPrices { get; set; }
    }
}
