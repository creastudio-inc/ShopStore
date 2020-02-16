using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Inventory
{
    public class Warehouse
    {
        public string Name { get; set; }


        public Vendors Vendor { get; set; }

      //  public Address Address { get; set; }
    }
}
