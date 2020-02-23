using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Activity : EntityBase
    {
        public string Description { get; set; }

        [ForeignKey("ActivityType")]
        public Guid ActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
