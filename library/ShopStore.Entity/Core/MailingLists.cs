using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class MailingLists : EntityBase
    {
        public string Email { get; set; }
        public bool UnSubscribe { get; set; }
    }
}
