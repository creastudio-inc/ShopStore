using ShopStore.Entity.ActivityLog;
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
    }

}
