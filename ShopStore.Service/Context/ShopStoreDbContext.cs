using ShopStore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Service.Context
{
    class ShopStoreDbContext : DbContext
    {
        public DbSet<Activity> ActivityContext { get; set; }
        public DbSet<ActivityType> ActivityTypeContext { get; set; }
        public DbSet<Vendor> VendorContext { get; set; }
        public DbSet<VendorCategory> VendorCategoryContext { get; set; }
        public DbSet<WishList> WishListContext { get; set; }
        public DbSet<WishListItem> WishListItemContext { get; set; }
        public DbSet<Shipment> ShipmentContext { get; set; }
        public DbSet<ShipmentItem> ShipmentItemContext { get; set; }
        public DbSet<Review> ReviewContext { get; set; }
        public DbSet<Reply> ReplyContext { get; set; }
        public DbSet<Payment> PaymentContext { get; set; }
        public DbSet<PaymentDetails> PaymentDetailsContext { get; set; }
        public DbSet<PaymentProvider> PaymentProviderContext { get; set; }
    }

}
