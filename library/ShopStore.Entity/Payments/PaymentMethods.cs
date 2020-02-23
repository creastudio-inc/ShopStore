using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class PaymentMethods : EntityBase
    {

        public string PaymentMethodName { get; set; }
        public string PaymentMethodDescription { get; set; }
        public Guid PaymentMethodLogo { get; set; }
         public DateTime PaymentMethodCreatedDate { get; set; }
         public bool Active { get; set; } 
        public PaymentMethodTypes PaymentMethodType { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
