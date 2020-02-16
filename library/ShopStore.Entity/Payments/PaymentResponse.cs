using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public class PaymentResponse
    {
        public bool SignatureMatch { get; set; }
        public virtual ICollection<PaymentResponseDetails> PaymentResponseDetails { get; set; }
    }
}
