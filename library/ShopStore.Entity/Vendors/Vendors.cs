using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class Vendors
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Email { get; set; }
        public virtual VendorsCategories VendorsCategories { get; set; }
    }
}
