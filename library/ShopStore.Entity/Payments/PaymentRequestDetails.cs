using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class PaymentRequestDetails : EntityBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual PaymentRequests PaymentRequests { get; set; }
    }
}
