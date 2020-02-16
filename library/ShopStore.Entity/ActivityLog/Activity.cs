using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.ActivityLog
{
    public class Activity
    {
        public string Description { get; set; }

        public ActivityType ActivityType { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
