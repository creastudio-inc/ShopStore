using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopStore.Entity
{
    public class User : IdentityUser<Guid>
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string FullName { get; set; }

        public long? VendorId { get; set; }

        public bool IsDeleted { get; set; }

        public IList<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

        [ForeignKey("DefaultShippingAddress")]
        public Guid? DefaultShippingAddressId { get; set; }

        [ForeignKey("DefaultBillingAddress")]
        public UserAddress DefaultShippingAddress { get; set; }

        public long? DefaultBillingAddressId { get; set; }
        public UserAddress DefaultBillingAddress { get; set; }

        [StringLength(450)]
        public string RefreshTokenHash { get; set; }

        public IList<UserRole> Roles { get; set; } = new List<UserRole>();

        public IList<CustomerGroupUser> CustomerGroups { get; set; } = new List<CustomerGroupUser>();

        [StringLength(450)]
        public string Culture { get; set; }

        /// <inheritdoc />
        public string ExtensionData { get; set; }
    }
}