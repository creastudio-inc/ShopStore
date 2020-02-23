using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Inventory
{
    public class Warehouse : EntityBase
    {
        public string Name { get; set; }


        public Vendors Vendor { get; set; }

      //  public Address Address { get; set; }
    }
}
