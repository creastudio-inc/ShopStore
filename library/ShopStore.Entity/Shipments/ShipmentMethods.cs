using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class ShipmentMethods
    {
        public string AdditionalValue { get; set; }
        public bool RequiredVaildEmail { get; set; }
        public bool RequiredVaildMobile { get; set; }
        public string DeliveryEstimatedTime { get; set; }
        public string FreeShippingOnAmount { get; set; }
        public ShipmentItemWeights ShipmentItemWeights { get; set; }
        public ShipmentMethodTypes ShipmentMethodTypes { get; set; }
        public decimal ItemWeight { get; set; }
        public bool VatIncluded { get; set; }
    }
}
