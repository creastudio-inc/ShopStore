using ShopStore.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Products
    {
        public int SuggestedCount { get; set; }
         public string Label { get; set; }
  
        public ProductStatus ProductStatus { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool AllowBetting { get; set; }
        public int VisitedCount { get; set; }
        public Guid? CitiesID { get; set; }
        public DateTime? EndDate { get; set; }
        public bool ProductSets { get; set; }
        public bool PreOrder { get; set; }
        public int? PreOrderRequiredDays { get; set; }
        public bool ShowAsNotAvailableStock { get; set; }
        public string Code { get; set; } 
         public DateTime? StartDate { get; set; }
        public Cities Cities { get; set; }
        public virtual ProductTypes ProductTypes { get; set; }
        public virtual Products MainProducts { get; set; }
        public virtual ProductCategories ProductCategories { get; set; }

        public virtual Brands Brands { get; set; }
        public virtual ICollection<ProductBatchDefinitions> ProductBatchDefinitionsList { get; set; }
        public virtual ICollection<ProductDetailsTypesDetails> ProductDetailsTypesDetailsProducts { get; set; }
        public virtual ICollection<Sponsors> SponsorProducts { get; set; }
    }
}
