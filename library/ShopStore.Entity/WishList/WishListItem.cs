using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class WishListItem
    {
        public WishList WishList { get; set; }

        public Products Product { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }
    }
}
