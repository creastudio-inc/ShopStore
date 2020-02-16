using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Orders
{
 public    class OrderHistory
    {
        public long OrderId { get; set; }

        public Order Order { get; set; }

        public OrderStatus? OldStatus { get; set; }

        public OrderStatus NewStatus { get; set; }

        public string OrderSnapshot { get; set; }

        public string Note { get; set; }

        public DateTimeOffset CreatedOn { get; set; }


     //   public User CreatedBy { get; set; }
    }
}
