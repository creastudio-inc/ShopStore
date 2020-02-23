using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
  public  class Loggers : EntityBase
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Thread { get; set; }
    }
}
