using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class MailingLists : EntityBase
    {
        public string Email { get; set; }
        public bool UnSubscribe { get; set; }
    }
}