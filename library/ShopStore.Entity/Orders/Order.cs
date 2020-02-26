using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity.Orders
{
    public class Order : EntityBase
    {
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }

        public User Customer { get; set; }

        [ForeignKey("LatestUpdatedBy")]
        public Guid LatestUpdatedById { get; set; }

        public User LatestUpdatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public Guid CreatedById { get; set; }

        public User CreatedBy { get; set; }

        [ForeignKey("Vendor")]
        public long? VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public string CouponCode { get; set; }
        public string CouponRuleName { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal SubTotal { get; set; }

        public decimal SubTotalWithDiscount { get; set; }

        [ForeignKey("ShippingAddress")]
        public Guid ShippingAddressId { get; set; }

        public OrderAddress ShippingAddress { get; set; }

        [ForeignKey("BillingAddress")]
        public Guid BillingAddressId { get; set; }

        public OrderAddress BillingAddress { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string OrderNote { get; set; }

        [ForeignKey("Parent")]
        public Guid? ParentId { get; set; }

        public Order Parent { get; set; }

        public bool IsMasterOrder { get; set; }

        public string ShippingMethod { get; set; }

        public decimal ShippingFeeAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal OrderTotal { get; set; }

        public string PaymentMethod { get; set; }

        public decimal PaymentFeeAmount { get; set; }
    }
}