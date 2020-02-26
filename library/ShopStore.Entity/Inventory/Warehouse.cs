using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity.Inventory
{
    public class Warehouse : EntityBase
    {
        public string Name { get; set; }

        [ForeignKey("Vendor")]
        public Guid VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public Address Address { get; set; }
    }
}