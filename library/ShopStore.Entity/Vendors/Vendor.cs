using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class Vendor : EntityBase
    {
        public string Name { get; set; }

        [ForeignKey("User")]
        public Guid? UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("VendorCategory")]
        public Guid? VendorCategoryId { get; set; }

        public virtual VendorCategory VendorCategory { get; set; }
    }
}