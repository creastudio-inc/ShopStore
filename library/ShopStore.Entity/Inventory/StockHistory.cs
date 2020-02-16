using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Inventory
{
  public   class StockHistory
    {
        public long ProductId { get; set; }

        public Products Product { get; set; }

        public long WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public long CreatedById { get; set; }

     //   public User CreatedBy { get; set; }

        public long AdjustedQuantity { get; set; }

       // [StringLength(1000)]
        public string Note { get; set; }
    }
}
