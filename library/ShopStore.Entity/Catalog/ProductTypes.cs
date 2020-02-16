using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class ProductTypes
    {
   
            public virtual ProductCategories ProductCategories { get; set; }
        public virtual ProductTypes MainProductTypes { get; set; }

    }
}
