using ShopStore.Infrastructure.Models;
using System;

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