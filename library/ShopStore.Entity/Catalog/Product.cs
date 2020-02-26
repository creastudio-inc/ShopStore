using ShopStore.Entity.ENUM;
using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopStore.Entity
{
    public class Product : EntityBase
    {
        [StringLength(450)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Specification { get; set; }
        public ProductStatus ProductStatus { get; set; }
          public bool ShowAsNotAvailableStock { get; set; }
        public string Code { get; set; }
          public virtual ProductTypes ProductTypes { get; set; }
         public virtual ProductCategories ProductCategories { get; set; }

        public virtual ICollection<ProductBatchDefinitions> ProductBatchDefinitionsList { get; set; }
        public virtual ICollection<ProductDetailsTypesDetails> ProductDetailsTypesDetailsProducts { get; set; }
 

        public int ReviewsCount { get; set; }

        public double? RatingAverage { get; set; }

        public long? BrandId { get; set; }
        public virtual Brands Brands { get; set; }

    }
}