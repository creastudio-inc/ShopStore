using Microsoft.AspNetCore.Identity;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace ShopStore.Entity
{
    public class Role : IdentityRole<Guid>, IEntityWithTypedId<Guid>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}