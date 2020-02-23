using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
   public  class Reply : EntityBase
    {
        [ForeignKey("Review")]
        public Guid ReviewId { get; set; }

        public Review Review { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public string Comment { get; set; }

        public string ReplierName { get; set; }

        public ReplyStatus Status { get; set; }

    }
}
