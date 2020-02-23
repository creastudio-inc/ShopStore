﻿using ShopStore.Entity.ENUM;
using ShopStore.Entity.Inventory;
using ShopStore.Entity.Orders;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Shipment : EntityBase
    {
        
       
        [StringLength(450)]
        public string TrackingNumber { get; set; }


        [ForeignKey("Order")]
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        [ForeignKey("Vendor")]
        public Guid? VendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        [ForeignKey("CreatedBy")]
        public Guid CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public ShipmentStatus ShipmentStatus { get; set; }

        public IList<ShipmentItem> Items { get; set; } = new List<ShipmentItem>();
    }
}
