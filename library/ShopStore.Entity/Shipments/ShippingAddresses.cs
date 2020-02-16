using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class ShippingAddresses
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Default { get; set; }
        public Guid CustomeruserId { get; set; }
        public Guid ShippingAddressUserID { get; set; }
        public DateTime ShippingAddressCreatedDate { get; set; }
        public string ShippingAddressMobileNumber { get; set; }
        public string ShippingAddressHouseNumber { get; set; }
        public string ShippingAddressWasel { get; set; }
        public string ShippingAddressArea { get; set; }
        public string ShippingAddressStreetName { get; set; }
        public virtual Cities Cities { get; set; }
        public Guid CitiesID { get; set; }
        public string ShippingAddressAddressLine2 { get; set; }
        public string ShippingAddressAddressLine1 { get; set; }
        public string ShippingAddressAddress { get; set; }
        public string FullName { get; set; }
        public string JsonGoogleMapAddress { get; set; }
        public string Email { get; set; }
    }
}
