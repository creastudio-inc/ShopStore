using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Invoices
    {
        public InvoiceCreatedBy InvoiceCreatedBy { get; set; }
        public Guid CustomeruserId { get; set; }
         public decimal Discount { get; set; }
        public double TotalPrice { get; set; }
        public string InvoiceNumber { get; set; }
        public string InoviceStatus { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual ShippingAddresses ShippingAddresses { get; set; }
        public virtual ShipmentMethods ShipmentMethods { get; set; }
        public virtual Payments Payments { get; set; }

    }
}
