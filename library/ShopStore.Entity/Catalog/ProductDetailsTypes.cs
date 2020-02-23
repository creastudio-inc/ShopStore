using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class ProductDetailsTypes : EntityBase
    {
        public DetailType DetailType { get; set; }
        public bool Mandatory { get; set; }
        public int Length { get; set; }
        public Guid? ProductTypesID { get; set; }
        public virtual ProductTypes ProductTypes { get; set; }
        public virtual ICollection<ProductDetailsTypesDetails> ProductDetailsTypesDetails { get; set; }
    }
}
