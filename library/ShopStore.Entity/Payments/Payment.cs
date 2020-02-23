using ShopStore.Entity.ENUM;
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
  public  class Payment : EntityBase
    {
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

      
        public decimal Amount { get; set; }

        public decimal PaymentFee { get; set; }

        [StringLength(450)]
        public string PaymentMethod { get; set; }

        [StringLength(450)]
        public string GatewayTransactionId { get; set; }

        public PaymentStatus Status { get; set; }

        public string FailureMessage { get; set; }
        public virtual ICollection<PaymentDetails> PaymentDetails { get; set; }

    }
}
