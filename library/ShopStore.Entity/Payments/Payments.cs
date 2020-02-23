using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
  public  class Payments : EntityBase
    {
        public double PaymentAmount { get; set; }
        public string PaymentReferenceCode { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime PaymentCreatedDate { get; set; }
         public DateTime? PaidDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public virtual PaymentMethods PaymentMethod { get; set; }
        public ICollection<PaymentRequests> PaymentRequests { get; set; }
    }
}
