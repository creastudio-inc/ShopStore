using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class PaymentConfigurations : EntityBase
    {
        public string ConfigurationName { get; set; }
        public string MerchantIdentifier { get; set; }
        public string Command { get; set; }
        public string AccessCode { get; set; }
        public string ReturnURL { get; set; }
        public string SHARequestPhrase { get; set; }
        public string SHAResponsePhrase { get; set; }
        public string Currency { get; set; }
        public bool Defuilt { get; set; }
        public virtual PaymentMethods PaymentMethods { get; set; }
    }
}
