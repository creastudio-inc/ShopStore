using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class WishList : EntityBase
    {
        public string SharingCode { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }
        public IList<WishListItem> Items { get; protected set; } = new List<WishListItem>();
    }
}