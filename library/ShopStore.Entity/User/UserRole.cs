using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class UserRole : IdentityUserRole<Guid>
    {
        [ForeignKey("User")]
        public override Guid UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Role")]
        public override Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}