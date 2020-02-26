using ShopStore.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace ShopStore.Entity
{
    public class PaymentProvider : EntityBase
    {
        [StringLength(450)]
        public string Name { get; set; }

        public bool IsEnabled { get; set; }

        [StringLength(450)]
        public string ConfigureUrl { get; set; }

        [StringLength(450)]
        public string LandingViewComponentName { get; set; }

        /// <summary>
        /// Additional setting for specific provider. Stored as json string.
        /// </summary>
        public string AdditionalSettings { get; set; }
    }
}