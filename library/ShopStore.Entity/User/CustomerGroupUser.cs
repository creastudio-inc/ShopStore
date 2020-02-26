using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class CustomerGroupUser
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("CustomerGroup")]
        public Guid CustomerGroupId { get; set; }

        public CustomerGroup CustomerGroup { get; set; }
    }
}