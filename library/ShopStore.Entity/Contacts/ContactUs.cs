using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class ContactUs : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}