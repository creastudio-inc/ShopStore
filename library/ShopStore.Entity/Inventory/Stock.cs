using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Inventory
{
    public class Stock : EntityBase
    {

        public Products Product { get; set; }


        public Warehouse Warehouse { get; set; }

        public int Quantity { get; set; }

        public int ReservedQuantity { get; set; }
    }
}
