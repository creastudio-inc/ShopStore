using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class FAQs : EntityBase
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Order { get; set; }
    }
}
