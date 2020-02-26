using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class Brands : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
    }
}