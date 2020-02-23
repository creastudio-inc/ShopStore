using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class InvoiceDetails : EntityBase
    {
        public decimal Commission { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public virtual Invoices Invoices { get; set; }
        public virtual ProductBatchItems ProductBatchItems { get; set; }

    }
}
