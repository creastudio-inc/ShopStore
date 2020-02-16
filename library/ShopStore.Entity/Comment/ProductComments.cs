using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public class ProductComments
    {
        public string CommentText { get; set; }
        public string CommenterName { get; set; }
        public CommentStatus Status { get; set; }
        public ProductComments Parent { get; set; }

    }
}
