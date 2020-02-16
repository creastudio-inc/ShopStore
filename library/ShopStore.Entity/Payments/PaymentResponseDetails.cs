using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public class PaymentResponseDetails
    {

        public string Name { get; set; }
        public string Value { get; set; }
        public Guid PaymentResponseID { get; set; }
        public virtual PaymentResponse PaymentResponse { get; set; }
    }
}
