using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity.Reviews
{
   public  class Reply
    {
        public long ReviewId { get; set; }

        public Review Review { get; set; }

        public long UserId { get; set; }

        //public User User { get; set; }

        public string Comment { get; set; }

        public string ReplierName { get; set; }

        public ReplyStatus Status { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
