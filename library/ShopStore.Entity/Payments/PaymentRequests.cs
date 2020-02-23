using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class PaymentRequests : EntityBase
    {

        public int PaymentRequestsID { get; set; }
        public bool Success { get; set; }
        public virtual PaymentResponse PaymentResponse { get; set; }
        public virtual Payments Payments { get; set; }
        public virtual ICollection<PaymentRequestDetails> PaymentRequestDetails { get; set; }
    }
}
