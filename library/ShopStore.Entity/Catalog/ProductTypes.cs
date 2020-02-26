using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class ProductTypes : EntityBase
    {
        public virtual ProductCategories ProductCategories { get; set; }
        public virtual ProductTypes MainProductTypes { get; set; }
    }
}