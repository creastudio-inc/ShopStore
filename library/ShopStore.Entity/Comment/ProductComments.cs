using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class ProductComments : EntityBase
    {
        public string CommentText { get; set; }
        public string CommenterName { get; set; }
        public CommentStatus Status { get; set; }
        public ProductComments Parent { get; set; }
    }
}