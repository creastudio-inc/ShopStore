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
   public  class Review : EntityBase
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public string ReviewerName { get; set; }

        public ReviewStatus Status { get; set; }


 

        public IList<Reply> Replies { get; protected set; } = new List<Reply>();
    }
}
