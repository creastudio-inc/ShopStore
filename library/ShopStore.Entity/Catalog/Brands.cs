using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Brands :  EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }

    }
}
