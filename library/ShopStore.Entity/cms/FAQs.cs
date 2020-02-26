using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class FAQs : EntityBase
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Order { get; set; }
    }
}