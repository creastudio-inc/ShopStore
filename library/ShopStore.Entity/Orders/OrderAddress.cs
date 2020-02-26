using ShopStore.Infrastructure.Models;

namespace ShopStore.Entity
{
    public class OrderAddress : EntityBase
    {
        public string ContactName { get; set; }

        public string Phone { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        //public District District { get; set; }

        // public StateOrProvince StateOrProvince { get; set; }

        public Country Country { get; set; }
    }
}