using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class WishList
    {


        public string SharingCode { get; set; }


        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }
        public User User { get; set; }
        public IList<WishListItem> Items { get; protected set; } = new List<WishListItem>();

    }
}
