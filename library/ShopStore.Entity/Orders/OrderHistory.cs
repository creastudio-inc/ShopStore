using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class OrderHistory : EntityBase
    {
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        public OrderStatus? OldStatus { get; set; }

        public OrderStatus NewStatus { get; set; }

        public string OrderSnapshot { get; set; }

        public string Note { get; set; }

        [ForeignKey("CreatedBy")]
        public Guid CreatedById { get; set; }

        public User CreatedBy { get; set; }
    }
}