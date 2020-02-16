using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Orders
{
  public   class OrderItem
    {
        public Order Order { get; set; }


        public Products Product { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxPercent { get; set; }
    }
}
