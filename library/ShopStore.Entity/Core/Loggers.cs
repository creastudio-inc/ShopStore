using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class Loggers : EntityBase
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string Thread { get; set; }
    }
}