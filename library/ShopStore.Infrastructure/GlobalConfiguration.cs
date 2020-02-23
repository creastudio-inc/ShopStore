using ShopStore.Infrastructure.Localization;
using System.Collections.Generic;

namespace ShopStore.Infrastructure
{
    public static class GlobalConfiguration
    {
        public static IList<Culture> Cultures { get; set; } = new List<Culture>();

        public static string DefaultCulture => "en-US";
    }
}