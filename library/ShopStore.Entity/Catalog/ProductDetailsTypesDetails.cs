using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class ProductDetailsTypesDetails : EntityBase
    {
        public Guid ProductDetailsTypesID { get; set; }
        public virtual ProductDetailsTypes ProductDetailsTypes { get; set; }
        public string ValueEn { get; set; }
        public string ValueAr { get; set; }
    }
}
