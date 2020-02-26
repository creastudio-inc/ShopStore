using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class PaymentDetails : EntityBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public PaymentDetailsType Type { get; set; }

        [ForeignKey("Payment")]
        public Guid PaymentID { get; set; }

        public virtual Payment Payment { get; set; }
    }
}