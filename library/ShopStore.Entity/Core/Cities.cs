using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class Cities : EntityBase
    {
        public virtual Country Countries { get; set; }
    }
}