using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Colors : EntityBase
    {
        public string name { get; set; }
        public string Code { get; set; }
    }
}
